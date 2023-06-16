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
    public class CheckValid : ServiceMiniStore<BillOrder>
    {
        MiniStoreContext _context;
        DbSet<BillOrder> _bill;
        public CheckValid()
        {
            _context = new MiniStoreContext();
            _bill = _context.Set<BillOrder>();
        }
        public string autoId(string id)
        {
            //BiXXXX
            string result = "";
            int billID =int .Parse(id.Substring(2,4));
            billID++;
            int digit = 4;
            string prefix = "Bi";
            string idString =billID.ToString().PadLeft(digit,'0');
            result= prefix + idString;
            return result;
        }
        public void AddBill(BillOrder id) {
            var lastRecord = _bill.OrderByDescending(record => record.IdBill).FirstOrDefault();
            if (lastRecord != null) {
            id.IdBill =autoId(lastRecord.IdBill);
            }
            else
            {
                id.IdBill=autoId("Bi0001");
            }
            _bill.Add(id);
            _context.SaveChanges();         
        }
    }
}
