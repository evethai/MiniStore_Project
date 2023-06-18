using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Revenue
    {
        public Revenue()
        {
            BillOrders = new HashSet<BillOrder>();
        }

        public DateTime DateRevenue { get; set; }
        public double? TotalRevenueOfDay { get; set; }

        public virtual ICollection<BillOrder> BillOrders { get; set; }
    }
}
