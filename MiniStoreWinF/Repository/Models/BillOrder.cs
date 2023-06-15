using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class BillOrder
    {
        public BillOrder()
        {
            Orders = new HashSet<Order>();
        }

        public string IdBill { get; set; }
        public double? Total { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
