using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Salary
    {
        public string IdSalary { get; set; }
        public string IdEmp { get; set; }
        public double? SalaryHour { get; set; }
        public double BasicSalary { get; set; }
        public double? SumSubSalary { get; set; }
        public double? SumAdvanceSalary { get; set; }
        public double TotalSalary { get; set; }
        public double Tax { get; set; }
        public double SalaryAfterTax { get; set; }
        public DateTime DateImonth { get; set; }
        public DateTime DateOmonth { get; set; }

        public virtual Employee IdEmpNavigation { get; set; }
    }
}
