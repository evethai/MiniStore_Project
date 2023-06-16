using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Voucher
    {
        public Voucher()
        {
            Orders = new HashSet<Order>();
        }

        public int IdVoucher { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double? Price { get; set; }
        public int? Quantity { get; set; }
        public DateTime? Exp { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
