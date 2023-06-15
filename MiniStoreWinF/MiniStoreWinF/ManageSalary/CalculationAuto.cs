using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStoreWinF.ManageSalary
{
    public class CalculationAuto
    {
        EmployeeService _employeeService;
        PermissionService _permissionService;
        WorkSheetService _workSheetService;
        SheetDetailService _sheetDetailService;
        SubSalaryService _subSalaryService;
        DetailSubSalaryService _detailSubSalaryService;
        DetailAdvanceSalaryService _detailAdvanceSalaryService;
        SalaryService _salaryService;
        Utinity u = new Utinity();

        //tìm salary theo giờ của mỗi loại nhân viên
        public double HourSalary(string id)
        {

            _employeeService = new EmployeeService();
            _permissionService = new PermissionService();

            var listEmp = _employeeService.GetAll().Where(p=>p.IsActive==true).ToList();
            var listPer = _permissionService.GetAll().ToList();

            var result = (from emp in listEmp
                          join perm in listPer
                         on emp.Roles equals perm.Roles
                          where emp.IdEmp == id
                          select perm.BasicSalary).FirstOrDefault();
            if (result.HasValue)
            {
                return result.Value;
            }
            else
            {
                return 0;
            }
        }

        //tính thuế thu nhập cá nhân đối với mỗi nhân viên theo lũy tuyến 
        public double Tax(string id, DateTime time, double basicsalary)
        {
            _employeeService = new EmployeeService();
            _permissionService = new PermissionService();

            double tax=0;
            double tax_total = 0;

            var listEmp = _employeeService.GetAll().Where(p => p.IsActive == true).ToList();
            var listPer = _permissionService.GetAll().ToList();

            
            var result = (from emp in listEmp
                          join perm in listPer
                         on emp.Roles equals perm.Roles
                          where emp.IdEmp == id
                          select perm.Tax).FirstOrDefault();
            if (result.HasValue)
            {
                tax=basicsalary-result.Value;
                if(tax>0 &&tax <= 5000000) {
                    tax_total = 5 / 100.0;
                }else if (tax > 5000000 && tax <= 10000000) {
                    tax_total = 10 / 100.0;
                }else if (tax > 10000000 && tax <= 18000000)
                {
                    tax_total = 15 / 100.0;
                }
                return tax_total;
            }
            else
            {
                return tax_total;
            }
        }

        //tính lương cơ bản của mỗi nhân viên theo giờ làm việc và hệ số cộng thêm 
        public double BasicSalary(string id, DateTime time, double h_salary)
        {
            double result = 0;
            List<int?> sheet = new List<int?>();
            List<double> conffient = new List<double>();
            _workSheetService = new WorkSheetService();
            _sheetDetailService = new SheetDetailService();
            var listWS = _workSheetService.GetAll().ToList();
            var listDetail = _sheetDetailService.GetAll().ToList();

            var listCon = (from ws in listWS
                           join sd in listDetail
                           on ws.Sheet equals sd.Sheet
                           where ws.IdEmp == id && ws.Date.Value.Month == time.Month
                           select Tuple.Create(sd.CoefficientsSalary, (ws.TimeCheckOut.Value.TimeOfDay - ws.TimeCheckIn.Value.TimeOfDay))).ToList();
            foreach (var c in listCon)
            {
                double hour = (double)c.Item2.TotalHours;
                double coeff = (double)c.Item1;
                result += Math.Abs(h_salary * hour * coeff);
            }
            return result;
        }

        //tính tổng số sub salary của mỗi nhân viên
        public double SubSalary(string id, DateTime time)
        {
            double total = 0;
            _subSalaryService = new SubSalaryService();
            _detailSubSalaryService = new DetailSubSalaryService();
            var listSub = _subSalaryService.GetAll().ToList();
            var listDetail = _detailSubSalaryService.GetAll().Where(p=>p.ActiveSub==true).ToList();

            var listTotal = (from s in listSub
                             join
                             d in listDetail on s.IdDetailSubSalary equals d.IdDetailSubSalary
                             where s.IdEmp == id && s.Time.Value.Month == time.Month
                             select d.SubsidiesSalary).ToList();
            foreach (var lt in listTotal)
            {
                total += lt.Value;
            }
            return total;
        }

        //tổng số tiền lương ứng trong tháng của nhân viên
        public double AdvSalary(string id, DateTime time)
        {
            Double? total = 0;
            _detailAdvanceSalaryService = new DetailAdvanceSalaryService();
            var list = _detailAdvanceSalaryService.GetAll().Where(p => p.IdEmp.Equals(id)
            && p.DateAs.Value.Month == time.Month);
            foreach (var adv in list)
            {
                total += adv.AdvanceSalary;
            }
            return (double)total;
        }

        //kết quả lương của mỗi nhân viên khi chưa tính thuế thu nhập cá nhân 
        public double totalSalry(string id, DateTime time)
        {
            double total = 0;
            total = BasicSalary(id, time, HourSalary(id))
                + SubSalary(id, time)
                - AdvSalary(id, time);
            return total;
        }

        //số tiền lương cuối cùng sau khi đã trừ thuế
        public double sumaryResultTotalSalary(string id, DateTime time)
        {
            double result = 0;
            result = totalSalry(id, time) - (BasicSalary(id, time, HourSalary(id)) * Tax(id,time,BasicSalary(id, time, HourSalary(id))));
            return result;
        }


        //tính toàn bộ và add vào database
        public void CalculatorSalary(DateTime time)
        {
            _employeeService = new EmployeeService();


            var list = _employeeService.GetAll().Where(p => p.IsActive == true).ToList();
            foreach (var employee in list)
            {
                _salaryService = new SalaryService();
                Salary salary = new Salary();
                int id = _salaryService.GetAll().Count();
                salary.IdSalary = u.GenerateAutoId(id,"SA");
                var nId = _salaryService.GetAll().Count(p => p.IdSalary.Equals(salary.IdSalary));
                if (nId > 0)
                {
                    id++;
                }
                else
                {
                    salary.IdEmp = employee.IdEmp;
                    salary.SalaryHour = HourSalary(employee.IdEmp);
                    salary.BasicSalary = BasicSalary(employee.IdEmp,time, HourSalary(employee.IdEmp));
                    salary.SumSubSalary = SubSalary(employee.IdEmp, time);
                    salary.SumAdvanceSalary = AdvSalary(employee.IdEmp, time);
                    salary.TotalSalary = totalSalry(employee.IdEmp, time);
                    salary.Tax = Tax(employee.IdEmp,time, BasicSalary(employee.IdEmp, time, HourSalary(employee.IdEmp)));
                    salary.SalaryAfterTax = sumaryResultTotalSalary(employee.IdEmp, time);
                    salary.DateImonth = u.GetFirstDayofMonth(time);
                    salary.DateOmonth = time;
                    _salaryService.Create(salary);
                }
            }
        }


    }
}
