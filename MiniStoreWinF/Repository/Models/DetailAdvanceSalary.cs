using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class DetailAdvanceSalary
    {
        public string IdAdvanceSalary { get; set; }
        public string IdEmp { get; set; }
        public DateTime? DateAs { get; set; }
        public string DescriptionA { get; set; }
        public double? AdvanceSalary { get; set; }

        public virtual Employee IdEmpNavigation { get; set; }
    }
}
