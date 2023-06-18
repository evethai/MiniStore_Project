using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Member
    {
        public Member()
        {
            Orders = new HashSet<Order>();
        }

        public string PhoneMember { get; set; }
        public int? Point { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime? DoB { get; set; }
        public DateTime? TimeCreate { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
