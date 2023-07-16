using Microsoft.EntityFrameworkCore;
using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStoreWinF.ManageSalary
{
    public class CalculationAuto
    {
        //no cmt
        EmployeeService _employeeService;
        PermissionService _permissionService;
        WorkSheetService _workSheetService;
        SubSalaryService _subSalaryService;
        SubDetailService _subDetailService;
        HeSoTinhLuongService _heSoTinhLuongService;
        DetailAdvanceSalaryService _detailAdvanceSalaryService;
        SalaryService _salaryService;
        Utinity u = new Utinity();

        //tìm salary theo giờ của mỗi loại nhân viên
        public double HourSalary(string id)
        {
            _employeeService = new EmployeeService();
            _permissionService = new PermissionService();

            var listEmp = _employeeService.GetAll().Where(p => p.IsActive == true).ToList();
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

        //tính tổng số sub salary của mỗi nhân viên
        public double SubSalary(string id, DateTime time)
        {
            double? total = 0;
            int n = u.sum(id, time);
            _subSalaryService = new SubSalaryService();
            _subDetailService = new SubDetailService();


            var listSubSa = _subSalaryService.GetAll().ToList();
            var listSubDetail = _subDetailService.GetAll().Where(p => p.IdEmp.Equals(id)).ToList();


            var listSED = (from sd in listSubDetail
                           join ss in listSubSa on sd.IdSub equals ss.IdSub
                           where sd.IdEmp == id && sd.Check == true
                           select ss).ToList();

            foreach (var ssd in listSED)
            {
                if (ssd.TimeEnd.Value.Date >= DateTime.Now.Date)
                {
                    var sdetail = _subDetailService.GetAll().Where(p => p.IdSub.Equals(ssd.IdSub)).FirstOrDefault();
                    if (sdetail.TimeEnd.Value.Date >= DateTime.Now.Date)
                    {
                        if (ssd.Type.Equals("M"))
                        {
                            if (n >= ssd.Condition)
                            {
                                total += ssd.Money;
                            }
                        }
                        else if (ssd.Type.Equals("D"))
                        {
                            total += (ssd.Money * n);
                        }
                    }
                    else
                    {
                        if (ssd.Type.Equals("D"))
                        {
                            int m = 0;
                            if (sdetail.TimeEnd >= u.GetFirstDayofMonth(time))
                            {
                                int begin = u.GetFirstDayofMonth(time).Day;
                                int end = sdetail.TimeEnd.Value.Day;
                                for (int i = begin; i <= end; i++)
                                {
                                    var daybyday = _workSheetService.GetAll().Where(p => p.IdEmp.Equals(id) &&
                                                                                    p.Status == true &&
                                                                                    p.Date.Value.Month.Equals(time.Month) &&
                                                                                    p.Date.Value.Year.Equals(time.Year) &&
                                                                                    p.Date.Value.Day.Equals(i)).FirstOrDefault();
                                    if (daybyday != null)
                                    {
                                        m++;
                                    }

                                }
                                total += (ssd.Money * m);
                            }
                        }
                    }
                }
                else
                {
                    if (ssd.Type.Equals("D"))
                    {
                        int m = 0;
                        if (ssd.TimeEnd >= u.GetFirstDayofMonth(time))
                        {
                            int begin = u.GetFirstDayofMonth(time).Day;
                            int end = ssd.TimeEnd.Value.Day;
                            for (int i = begin; i <= end; i++)
                            {
                                var daybyday = _workSheetService.GetAll().Where(p => p.IdEmp.Equals(id) &&
                                                                                p.Status == true &&
                                                                                p.Date.Value.Month.Equals(time.Month) &&
                                                                                p.Date.Value.Year.Equals(time.Year) &&
                                                                                p.Date.Value.Day.Equals(i)).FirstOrDefault();
                                if (daybyday != null)
                                {
                                    m++;
                                }

                            }
                            total += (ssd.Money * m);
                        }
                    }
                }
            }
            return (double)total;
        }

        //tính lương cơ bản của mỗi nhân viên theo giờ làm việc
        public double BasicSalary(string id, DateTime time, double h_salary, double phu_cap)
        {
            double? result = 0;
            _workSheetService = new WorkSheetService();
            var listWorkSheetToCalculateSalary = _workSheetService.GetAll().Where(
                p => p.IdEmp.Equals(id) &&
                p.Status == true &&
                p.Date.Value.Month.Equals(time.Month) &&
                p.Date.Value.Year.Equals(time.Year)).ToList();

            foreach (var ls in listWorkSheetToCalculateSalary)
            {
                result += (ls.TotalWorkingHours.Value.TotalHours) * (ls.DefaultCoefficient + ls.SundayCoefficient) * h_salary;
            }

            result = result + phu_cap;
            return (double)result;
        }

        public double thu_nhap_truoc_thue(double basicSalary)
        {
            double? total = 0;
            double? bhxh = 0;
            double? bhyt = 0;
            double? bhtn = 0;
            _heSoTinhLuongService = new HeSoTinhLuongService();
            var hstl = _heSoTinhLuongService.GetAll().FirstOrDefault();

            if (basicSalary >= hstl.MucBhToiDa)
            {
                bhxh = hstl.MucBhToiDa * hstl.Bhxh;
                bhyt = hstl.MucBhToiDa * hstl.Bhyt;
                bhtn = basicSalary * hstl.Bhtn;
                total = basicSalary - (bhxh + bhyt + bhtn);
            }
            else
            {
                bhxh = basicSalary * hstl.Bhxh;
                bhyt = basicSalary * hstl.Bhyt;
                bhtn = basicSalary * hstl.Bhtn;
                total = basicSalary - (bhxh + bhyt + bhtn);
            }
            return (double)total;

        }
        //tính thuế thu nhập cá nhân đối với mỗi nhân viên theo lũy tuyến 
        public double thue_thu_nhap_ca_nhan(string id, double thu_nhap_truoc_thue)
        {
            _employeeService = new EmployeeService();
            _heSoTinhLuongService = new HeSoTinhLuongService();

            double? thue_thu_nhap_ca_nhan = 0;
            double? thu_nhap_chiu_thue = 0;

            var emp = _employeeService.GetAll().Where(p => p.IdEmp.Equals(id) && p.IsActive == true).FirstOrDefault();
            var hstl = _heSoTinhLuongService.GetAll().FirstOrDefault();

            thu_nhap_chiu_thue = thu_nhap_truoc_thue - (hstl.GtgcBanthan) - (emp.Snpt * hstl.GtgcNpt);

            if (thu_nhap_chiu_thue <= 0)
            {
                thue_thu_nhap_ca_nhan = 0;
            }
            else
            {
                if (thu_nhap_chiu_thue > 0 && thu_nhap_chiu_thue <= 5000000)
                {
                    thue_thu_nhap_ca_nhan = thu_nhap_chiu_thue * 5 / 100;
                }
                else if (thu_nhap_chiu_thue > 5000000 && thu_nhap_chiu_thue <= 10000000)
                {
                    thue_thu_nhap_ca_nhan = thu_nhap_chiu_thue * 10 / 100 - 250000;
                }
                else if (thu_nhap_chiu_thue > 10000000 && thu_nhap_chiu_thue <= 18000000)
                {
                    thue_thu_nhap_ca_nhan = thu_nhap_chiu_thue * 15 / 100 - 750000;
                }
                else if (thu_nhap_chiu_thue > 18000000 && thu_nhap_chiu_thue <= 32000000)
                {
                    thue_thu_nhap_ca_nhan = thu_nhap_chiu_thue * 20 / 100 - 1650000;
                }
                else if (thu_nhap_chiu_thue > 32000000 && thu_nhap_chiu_thue <= 52000000)
                {
                    thue_thu_nhap_ca_nhan = thu_nhap_chiu_thue * 25 / 100 - 3250000;
                }
                else if (thu_nhap_chiu_thue > 52000000 && thu_nhap_chiu_thue < 80000000)
                {
                    thue_thu_nhap_ca_nhan = thu_nhap_chiu_thue * 30 / 100 - 5850000;
                }
                else if (thu_nhap_chiu_thue > 80000000)
                {
                    thue_thu_nhap_ca_nhan = thu_nhap_chiu_thue * 35 / 100 - 9850000;
                }
            }

            return (double)thue_thu_nhap_ca_nhan;
        }

        //tổng số tiền lương ứng trong tháng của nhân viên
        public double AdvSalary(string id, DateTime time)
        {
            double? total = 0;
            _detailAdvanceSalaryService = new DetailAdvanceSalaryService();
            var list = _detailAdvanceSalaryService.GetAll().Where(p => p.IdEmp.Equals(id)
            && p.DateAs.Value.Month == time.Month && p.DateAs.Value.Year == time.Year).ToList();
            foreach (var adv in list)
            {
                total += adv.AdvanceSalary;
            }
            return (double)total;
        }

        //số tiền lương cuối cùng sau khi đã khấu trừ
        public double FinalSalary(string id, DateTime time)
        {
            double total = 0;

            double hs = HourSalary(id);
            double ss = SubSalary(id, time);
            double bss = BasicSalary(id, time, hs, ss);
            double tntt = thu_nhap_truoc_thue(bss);
            double ttncn = thue_thu_nhap_ca_nhan(id, tntt);
            double adv = AdvSalary(id, time);

            total = tntt - ttncn - adv;

            return total;
        }

        //tính toàn bộ và add vào database
        public void CalculatorSalary(DateTime time)
        {
            _employeeService = new EmployeeService();
            _salaryService = new SalaryService();
            var list = _employeeService.GetAll().Where(p => p.IsActive == true && p.Roles!=0 && p.Roles!=1).ToList();
            foreach (var emp in list)
            {

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
                    //IdEmp
                    salary.IdEmp=emp.IdEmp;
                    //Salary by hour
                    salary.SalaryByHour = BasicSalary(emp.IdEmp, time, HourSalary(emp.IdEmp), 0);
                    //sub salary
                    salary.SubSalary = SubSalary(emp.IdEmp, time);
                    //Basic salary
                    salary.BasicSalary = BasicSalary(emp.IdEmp, time, HourSalary(emp.IdEmp), SubSalary(emp.IdEmp, time));
                    //Salary befor tax
                    salary.SalaryBeforTax = thu_nhap_truoc_thue(BasicSalary(emp.IdEmp, time, HourSalary(emp.IdEmp), SubSalary(emp.IdEmp, time)));
                    //Salary tax
                    salary.Tax = thue_thu_nhap_ca_nhan(emp.IdEmp, thu_nhap_truoc_thue(BasicSalary(emp.IdEmp, time, HourSalary(emp.IdEmp), SubSalary(emp.IdEmp, time))));
                    //Advance salary
                    salary.AdvSalary = AdvSalary(emp.IdEmp, time);
                    //Final salary
                    salary.FinalSalary = FinalSalary(emp.IdEmp, time);
                    //Date time begin month
                    salary.DateImonth = u.GetFirstDayofMonth(time);
                    //Date time end month
                    salary.DateOmonth = u.GetLastDayOfMonth(time);
                    //add into DB
                    _salaryService.Create(salary);
                }
            }
        }


    }
}
