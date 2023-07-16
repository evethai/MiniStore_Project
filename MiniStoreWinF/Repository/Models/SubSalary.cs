using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class SubSalary
    {
        public SubSalary()
        {
            SubDetails = new HashSet<SubDetail>();
        }

        public string IdSub { get; set; }
        public string Describe { get; set; }
        public double? Money { get; set; }
        public DateTime? TimeBegin { get; set; }
        public DateTime? TimeEnd { get; set; }
        public string Type { get; set; }
        public int? Condition { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<SubDetail> SubDetails { get; set; }
    }
}
