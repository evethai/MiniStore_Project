using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class SubType
    {
        public SubType()
        {
            SubSalaries = new HashSet<SubSalary>();
        }

        public string IdType { get; set; }
        public string Type { get; set; }
        public int? Condition { get; set; }

        public virtual ICollection<SubSalary> SubSalaries { get; set; }
    }
}
