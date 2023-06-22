using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Database.Controllers
{
    public class SheetDetailDTO
    {
        public int Sheet { get; set; }
        public string ShiftStartTime { get; set; }
        public string ShiftEndTime { get; set; }
    }
}