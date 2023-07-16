using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class SubDetail
    {
        public string IdDetail { get; set; }
        public string IdEmp { get; set; }
        public string IdSub { get; set; }
        public DateTime? TimeBegin { get; set; }
        public DateTime? TimeEnd { get; set; }
        public bool? Check { get; set; }

        public virtual Employee IdEmpNavigation { get; set; }
        public virtual SubSalary IdSubNavigation { get; set; }
    }
}
