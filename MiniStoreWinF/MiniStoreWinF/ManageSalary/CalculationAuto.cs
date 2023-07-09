using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStoreWinF.ManageSalary
{
    public class CalculationAuto
    {
        //no cmt
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
        public double Tax(string id, DateTime time, double salary)
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
                tax=salary-result.Value;
                //
                if(tax>0 &&tax <= 5000000) {
                    tax_total =salary * 5/100;
                }else if (tax > 5000000 && tax <= 10000000)
                {
                    tax_total = salary * 10/100 - 250000;
                }else if (tax > 10000000 && tax <= 18000000)
                {
                    tax_total = salary * 15/100 -750000;
                }else if(tax >18000000 && tax <= 32000000)
                {
                    tax_total=salary* 20/100 -1650000;
                }else if(tax>32000000 && tax <= 52000000)
                {
                    tax_total = salary * 25/100 - 3250000;
                }else if(tax > 52000000 && tax < 80000000)
                {
                    tax_total = salary * 30/100 - 5850000;
                }else if(tax > 80000000)
                {
                    tax_total = salary * 35/100 - 9850000;
                }
                //
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
            var listWS = _workSheetService.GetAll().Where(p=>p.Status==true).ToList();
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
            double r = Math.Round(result, 2);
            return r;
        }

        //tính tổng số sub salary của mỗi nhân viên
        public double SubSalary(string id, DateTime time)
        {
            double total = 0;
            _subSalaryService = new SubSalaryService();
            _detailSubSalaryService = new DetailSubSalaryService();
            var listSub = _subSalaryService.GetAll().ToList();
            var listDetail = _detailSubSalaryService.GetAll().Where(p=>p.ActiveSub==true && p.DateEffect>= time).ToList();

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
            result = totalSalry(id, time) - (Tax(id,time,totalSalry(id,time)));
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
                    //id
                    salary.IdEmp = employee.IdEmp;
                    //salary hour
                    salary.SalaryHour = HourSalary(employee.IdEmp);
                    //basic salary
                    salary.BasicSalary = BasicSalary(employee.IdEmp,time, HourSalary(employee.IdEmp));
                    //sub salary
                    salary.SumSubSalary = SubSalary(employee.IdEmp, time);
                    //advance salary
                    salary.SumAdvanceSalary = AdvSalary(employee.IdEmp, time);
                    //total basic
                    salary.TotalSalary = totalSalry(employee.IdEmp, time);
                    //tax
                    salary.Tax = Tax(employee.IdEmp,time,totalSalry(employee.IdEmp, time));
                    //after tax
                    salary.SalaryAfterTax = sumaryResultTotalSalary(employee.IdEmp, time);
                    //day begin 
                    salary.DateImonth = u.GetFirstDayofMonth(time);
                    //day close month
                    salary.DateOmonth = u.GetLastDayOfMonth(time);
                    //add into
                    _salaryService.Create(salary);
                }
            }
        }


    }
}
