using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class CodeVoucher
    {
        public string Id { get; set; }
        public string IdVoucher { get; set; }
        public int? QuantityValue { get; set; }
        public bool? StatusV { get; set; }

        public virtual Voucher IdVoucherNavigation { get; set; }
    }
}
