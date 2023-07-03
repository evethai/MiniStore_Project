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

        public string IdBillOrder { get; set; }
        public double? TotalBill { get; set; }
        public DateTime? DateOfBill { get; set; }
        public string PhoneMember { get; set; }
        public string IdVoucher { get; set; }
        public double? DiscountPrice { get; set; }

        public virtual Revenue DateOfBillNavigation { get; set; }
        public virtual Voucher IdVoucherNavigation { get; set; }
        public virtual Member PhoneMemberNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
