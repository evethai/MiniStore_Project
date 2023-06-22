using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class MoMo
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Gmail { get; set; }
        public bool? Active { get; set; }
    }
}
