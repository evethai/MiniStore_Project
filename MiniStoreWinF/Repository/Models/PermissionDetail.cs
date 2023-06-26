using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class PermissionDetail
    {
        public int Id { get; set; }
        public int? IdPer { get; set; }
        public string ActionName { get; set; }
        public string ActionCode { get; set; }
        public bool? CheckAction { get; set; }

        public virtual Permission IdPerNavigation { get; set; }
    }
}
