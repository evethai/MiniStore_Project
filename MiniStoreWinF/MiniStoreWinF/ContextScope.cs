﻿using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStoreWinF
{
    public static class ContextScope
    {
        public static Employee? currentEmployee { get; set; }
        public static MoMo currentMoMo { get; set; }
        public static DateTime currentDate { get; set; }
    }
}