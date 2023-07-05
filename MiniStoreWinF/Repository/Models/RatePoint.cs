using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class RatePoint
    {
        public RatePoint()
        {
            Members = new HashSet<Member>();
        }

        public string IdRate { get; set; }
        public int? RateUsing { get; set; }
        public int? RateTaking { get; set; }
        public bool? StatusRp { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }
}
