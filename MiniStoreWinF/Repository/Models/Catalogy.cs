using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Catalogy
    {
        public Catalogy()
        {
            Products = new HashSet<Product>();
        }

        public int IdCa { get; set; }
        public string ProductType { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
