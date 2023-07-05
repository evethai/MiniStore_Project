using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Product
    {
        public Product()
        {
            Units = new HashSet<Unit>();
        }

        public string Sku { get; set; }
        public string ProductType { get; set; }
        public string NameProduct { get; set; }
        public string IdSupplier { get; set; }
        public DateTime? Mfg { get; set; }
        public DateTime? Exp { get; set; }
        public DateTime? DateImport { get; set; }
        public bool? StatusP { get; set; }
        public string PictureProduct { get; set; }

        public virtual Supplier IdSupplierNavigation { get; set; }
        public virtual Catalogy ProductTypeNavigation { get; set; }
        public virtual ICollection<Unit> Units { get; set; }
    }
}
