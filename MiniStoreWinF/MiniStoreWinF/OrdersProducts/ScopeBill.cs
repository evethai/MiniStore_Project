
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
    }
}
