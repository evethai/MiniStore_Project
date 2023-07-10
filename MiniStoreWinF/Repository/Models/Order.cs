using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Order
    {
        public string IdOrder { get; set; }
        public string IdEmp { get; set; }
        public int? QuantityOrders { get; set; }
        public DateTime? DateOrders { get; set; }
        public string IdBillOrder { get; set; }
        public double? Total { get; set; }
        public string IdUnit { get; set; }

        public virtual BillOrder IdBillOrderNavigation { get; set; }
        public virtual Employee IdEmpNavigation { get; set; }
        public virtual Unit IdUnitNavigation { get; set; }
    }
}
