using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Products = new HashSet<Product>();
        }

        public string IdSupplier { get; set; }
        public string NameSupplier { get; set; }
        public string AddressSupplier { get; set; }
        public string Note { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
