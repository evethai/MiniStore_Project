using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace MiniStoreWinF.ManageSalary
{
    public class UpdateAuto
    {
        EmployeeService _employeeService;
        DetailSubSalaryService _detailSubSalaryService;
        SubSalaryService _subSalaryService;
        Utinity u = new Utinity();

        public void save(DateTime time)
        {
            _employeeService = new EmployeeService();
            _detailSubSalaryService = new DetailSubSalaryService();
            List<Employee> employees = new List<Employee>();
            double? total = 0;
            var listEmp = _employeeService.GetAll().Where(p => p.IsActive == true).ToList();
            var listSub = _detailSubSalaryService.GetAll().Where(p=>p.ActiveSub==true && p.DateEffect>= time).ToList();
            foreach (var emp in listEmp)
            {
                int n = u.sum(emp.IdEmp, time);
                foreach (var subDetail in listSub)
                {
                    if (n >= subDetail.Condition)
                    {
                        //list employee over conditon to entitled sub salary
                        employees.Add(emp);
                    }
                    //foreach (var item in employees)
                    //{
                    //    _subSalaryService = new SubSalaryService();
                    //    //SubSalary subSalary = new SubSalary();
                    //    //int id = _subSalaryService.GetAll().Count();
                    //    //subSalary.IdSubSalary = u.GenerateAutoId(id,"SUB");
                    //    //var nId = _subSalaryService.GetAll().Count(p => p.IdSubSalary.Equals(subSalary.IdSubSalary));
                    //    //if (nId > 0)
                    //    //{
                    //    //    id++;
                    //    //}
                    //    //else
                    //    //{
                    //    //    //subSalary.IdEmp=item.IdEmp;
                    //    //    //subSalary.Time=time;
                    //    //    //subSalary.IdDetailSubSalary = subDetail.IdDetailSubSalary;
                    //    //    _subSalaryService.Create(subSalary);
                    //    //}                    //salary.TotalSalary = totalSalry(employee.IdEmp, time);
                    ////tax
                    //salary.Tax = Tax(employee.IdEmp,time,totalSalry(employee.IdEmp, time));
                    ////after tax
                    //salary.SalaryAfterTax = sumaryResultTotalSalary(employee.IdEmp, time);
                    //}
                    employees.Clear();
                }
            }
        }

    }
}
