using Microsoft.EntityFrameworkCore;
using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStoreWinF.DashBoard
{
    public class AutoWorkSheetID : ServiceMiniStore<WorkSheet>
    {
        MiniStoreContext _context;
        DbSet<WorkSheet> _worksheet;
        public AutoWorkSheetID()
        {
            _context = new MiniStoreContext();
            _worksheet = _context.Set<WorkSheet>();
        }
        public string autoId(string id)
        {
            //WSXXXX
            string result = "";
            int worksheetID = int.Parse(id.Substring(2, 3));
            worksheetID++;
            int digit = 3;
            string prefix = "WS";
            string idString = worksheetID.ToString().PadLeft(digit, '0');
            result = prefix + idString;
            return result;
        }
        public void AddID(WorkSheet id)
        {
            var lastRecord = _worksheet.OrderByDescending(record => record.IdWorkSheet).FirstOrDefault();
            if (lastRecord != null)
            {
                id.IdWorkSheet = autoId(lastRecord.IdWorkSheet);
            }
            else
            {
                id.IdWorkSheet = autoId("WS001");
            }
            _worksheet.Add(id);
            _context.SaveChanges();
        }
    }
}

