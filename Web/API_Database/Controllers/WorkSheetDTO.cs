﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Database.Controllers
{
    public class WorkSheetDTO
    {
        public string Status { get; set; }
        public int Sheet { get; set; }
        public DateTime Date { get; set; }

        public DateTime TimeCheckIn { get; set; }
        public DateTime TimeCheckOut { get; set; }
    }
}