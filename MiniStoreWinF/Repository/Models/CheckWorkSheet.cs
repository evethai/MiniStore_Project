using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class CheckWorkSheet
    {
        public int IdCheck { get; set; }
        public string UserWork { get; set; }
        public DateTime? TimeCheckIn { get; set; }
        public DateTime? TimeCheckOut { get; set; }
    }
}
