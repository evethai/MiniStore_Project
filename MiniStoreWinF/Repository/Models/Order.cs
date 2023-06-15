using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Order
    {
        public string IdOrder { get; set; }
        public string Sku { get; set; }
        public string PhoneMember { get; set; }
        public string IdEmp { get; set; }
        public int? QuantityOrders { get; set; }
        public string NameProduct { get; set; }
        public double? PriceProduct { get; set; }
        public DateTime? DateOrders { get; set; }
        public double? Total { get; set; }
        public string IdBill { get; set; }
        public int? IdVoucher { get; set; }

        public virtual Revenue DateOrdersNavigation { get; set; }
        public virtual BillOrder IdBillNavigation { get; set; }
        public virtual Employee IdEmpNavigation { get; set; }
        public virtual Voucher IdVoucherNavigation { get; set; }
        public virtual Member PhoneMemberNavigation { get; set; }
        public virtual Product SkuNavigation { get; set; }
    }
}
