using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class DetailSubSalary
    {
        public DetailSubSalary()
        {
            SubSalaries = new HashSet<SubSalary>();
        }

        public string IdDetailSubSalary { get; set; }
        public string DescriptionA { get; set; }
        public double? SubsidiesSalary { get; set; }
        public int? Condition { get; set; }
        public bool? ActiveSub { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateEffect { get; set; }

        public virtual ICollection<SubSalary> SubSalaries { get; set; }
    }
}
