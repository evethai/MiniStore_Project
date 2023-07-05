using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Member
    {
        public Member()
        {
            BillOrders = new HashSet<BillOrder>();
        }

        public string PhoneMember { get; set; }
        public int? Point { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime? DoB { get; set; }
        public DateTime? TimeCreate { get; set; }
        public string IdRate { get; set; }

        public virtual RatePoint IdRateNavigation { get; set; }
        public virtual ICollection<BillOrder> BillOrders { get; set; }
    }
}
