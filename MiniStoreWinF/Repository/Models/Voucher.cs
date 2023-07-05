using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Voucher
    {
        public Voucher()
        {
            BillOrders = new HashSet<BillOrder>();
            CodeVouchers = new HashSet<CodeVoucher>();
        }

        public string IdVoucher { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public int? Quantity { get; set; }
        public DateTime? Exp { get; set; }
        public double? Conditions { get; set; }

        public virtual ICollection<BillOrder> BillOrders { get; set; }
        public virtual ICollection<CodeVoucher> CodeVouchers { get; set; }
    }
}
