using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Revenue
    {
        public Revenue()
        {
            Orders = new HashSet<Order>();
        }

        public DateTime DateOrders { get; set; }
        public double? TotalRevenueOfDay { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
