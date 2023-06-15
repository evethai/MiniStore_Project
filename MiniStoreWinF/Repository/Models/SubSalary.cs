using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class SubSalary
    {
        public string IdSubSalary { get; set; }
        public string IdEmp { get; set; }
        public string IdDetailSubSalary { get; set; }
        public DateTime? Time { get; set; }

        public virtual DetailSubSalary IdDetailSubSalaryNavigation { get; set; }
        public virtual Employee IdEmpNavigation { get; set; }
    }
}
