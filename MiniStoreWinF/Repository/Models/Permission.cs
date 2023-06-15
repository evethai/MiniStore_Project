using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Permission
    {
        public Permission()
        {
            Employees = new HashSet<Employee>();
        }

        public string Roles { get; set; }
        public string Permission1 { get; set; }
        public double? BasicSalary { get; set; }
        public double? Tax { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
