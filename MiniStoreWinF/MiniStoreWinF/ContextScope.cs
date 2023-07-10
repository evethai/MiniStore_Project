using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace MiniStoreWinF
{
    public static class ContextScope
    {
        public static Employee? currentEmployee { get; set; }
        public static MoMo currentMoMo { get; set; }
        public static DateTime currentDate { get; set; }
        public static DetailSubSalary currentSubSalary { get; set;}
        public static Order IdOrder { get; set; }
        public static Product productInfor { get; set; }
        public static Unit unitInfor { get; set; }
        public static Supplier supplierInfor { get; set; }
    }
}
