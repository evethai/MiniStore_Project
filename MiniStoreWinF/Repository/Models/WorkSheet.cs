using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class WorkSheet
    {
        public string IdWorkSheet { get; set; }
        public string IdEmp { get; set; }
        public DateTime? Date { get; set; }
        public int? Sheet { get; set; }
        public DateTime? TimeCheckIn { get; set; }
        public DateTime? TimeCheckOut { get; set; }
        public bool? Status { get; set; }
        public TimeSpan? TotalWorkingHours { get; set; }

        public virtual Employee IdEmpNavigation { get; set; }
        public virtual SheetDetail SheetNavigation { get; set; }
    }
}
