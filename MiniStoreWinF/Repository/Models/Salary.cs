using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Salary
    {
        public string IdSalary { get; set; }
        public string IdEmp { get; set; }
        public double? SalaryByHour { get; set; }
        public double? SubSalary { get; set; }
        public double BasicSalary { get; set; }
        public double SalaryBeforTax { get; set; }
        public double Tax { get; set; }
        public double? AdvSalary { get; set; }
        public double? FinalSalary { get; set; }
        public DateTime DateImonth { get; set; }
        public DateTime DateOmonth { get; set; }

        public virtual Employee IdEmpNavigation { get; set; }
    }
}
