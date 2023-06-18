using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        public string Sku { get; set; }
        public string ProductType { get; set; }
        public string NameProduct { get; set; }
        public int? QuantityProduct { get; set; }
        public double? PriceProduct { get; set; }
        public string PictureProduct { get; set; }
        public bool? StatusP { get; set; }
        public DateTime? Mfg { get; set; }
        public DateTime? Exp { get; set; }

        public virtual Catalogy ProductTypeNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
