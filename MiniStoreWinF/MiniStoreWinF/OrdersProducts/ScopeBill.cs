
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStoreWinF.OrdersProducts
{
    public static class ScopeBill
    {
        public static BillOrder currentBill { get; set; }
        public static string GenerateAutoId(int currentCount, string headId)
        {
            int nextCount = currentCount + 1;
            string id = headId + nextCount.ToString("D4");
            return id;
        }
    }
}
