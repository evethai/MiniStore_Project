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
        public string Date { get; set; }

        public string TimeCheckIn { get; set; }
        public string TimeCheckOut { get; set; }
    }
}