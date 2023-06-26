using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Employee
    {
        public Employee()
        {
            DetailAdvanceSalaries = new HashSet<DetailAdvanceSalary>();
            Orders = new HashSet<Order>();
            Salaries = new HashSet<Salary>();
            SubSalaries = new HashSet<SubSalary>();
            WorkSheets = new HashSet<WorkSheet>();
        }

        public string IdEmp { get; set; }
        public string FullNameEmp { get; set; }
        public bool? Sex { get; set; }
        public string Cccd { get; set; }
        public DateTime? DoB { get; set; }
        public string AddressEmp { get; set; }
        public string PhoneEmp { get; set; }
        public DateTime? DateJoin { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? Roles { get; set; }
        public bool? IsActive { get; set; }
        public string PictureEmp { get; set; }

        public virtual Permission RolesNavigation { get; set; }
        public virtual ICollection<DetailAdvanceSalary> DetailAdvanceSalaries { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Salary> Salaries { get; set; }
        public virtual ICollection<SubSalary> SubSalaries { get; set; }
        public virtual ICollection<WorkSheet> WorkSheets { get; set; }
    }
}
