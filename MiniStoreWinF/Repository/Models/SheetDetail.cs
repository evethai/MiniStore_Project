using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class SheetDetail
    {
        public SheetDetail()
        {
            WorkSheets = new HashSet<WorkSheet>();
        }

        public int Sheet { get; set; }
        public string DescriptionS { get; set; }
        public double? CoefficientsSalary { get; set; }
        public TimeSpan? ShiftStartTime { get; set; }
        public TimeSpan? ShiftEndTime { get; set; }

        public virtual ICollection<WorkSheet> WorkSheets { get; set; }
    }
}
