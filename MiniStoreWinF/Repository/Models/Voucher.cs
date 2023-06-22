using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Voucher
    {
        public Voucher()
        {
            CodeVouchers = new HashSet<CodeVoucher>();
            Orders = new HashSet<Order>();
        }

        public string IdVoucher { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public int? Quantity { get; set; }
        public DateTime? Exp { get; set; }
        public double? Conditions { get; set; }

        public virtual ICollection<CodeVoucher> CodeVouchers { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
