using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Unit
    {
        public Unit()
        {
            Orders = new HashSet<Order>();
        }

        public string IdUnit { get; set; }
        public string Sku { get; set; }
        public string UnitName { get; set; }
        public int? QuantityUnit { get; set; }
        public double? PriceImport { get; set; }
        public double? PriceExport { get; set; }

        public virtual Product SkuNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
