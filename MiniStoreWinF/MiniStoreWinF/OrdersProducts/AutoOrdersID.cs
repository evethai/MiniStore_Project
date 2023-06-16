using Microsoft.EntityFrameworkCore;
using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStoreWinF.OrdersProducts
{
    internal class AutoOrdersID :ServiceMiniStore<Order>
    {
        MiniStoreContext _context;
        DbSet<Order> _bill;
        public AutoOrdersID()
        {
            _context = new MiniStoreContext();
            _bill = _context.Set<Order>();
        }
        public string autoId(string id)
        {
            //BiXXXX
            string result = "";
            int billID = int.Parse(id.Substring(2, 4));
            billID++;
            int digit = 4;
            string prefix = "Or";
            string idString = billID.ToString().PadLeft(digit, '0');
            result = prefix + idString;
            return result;
        }
        public void AddBill(Order id)
        {
            var lastRecord = _bill.OrderByDescending(record => record.IdOrder).FirstOrDefault();
            if (lastRecord != null)
            {
                id.IdOrder = autoId(lastRecord.IdOrder);
            }
            else
            {
                id.IdOrder = autoId("Or0000");
            }
            _bill.Add(id);
            _context.SaveChanges();
        }
    }
}
