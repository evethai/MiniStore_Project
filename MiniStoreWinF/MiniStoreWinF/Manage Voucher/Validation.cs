using Microsoft.EntityFrameworkCore;
using Repository.Models;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStoreWinF.Manage_Voucher
{
    public class Validation : ServiceMiniStore<Voucher>
    {
        MiniStoreContext _context;
        DbSet<Voucher> _voucher;
        public Validation()
        {
            _context = new MiniStoreContext();
            _voucher = _context.Set<Voucher>();
        }
        public List<Voucher> GetName(string name)
        {
            var records = _voucher.Where(entity => entity.Name.Contains(name)).ToList();

            return records;
        }

        //public void Add(Voucher voucher)
        //{
        //    var lastRecord = _voucher.OrderByDescending(record => record.IdVoucher).FirstOrDefault();
        //    if (lastRecord != null)
        //    {
        //        voucher.IdVoucher = autoID(lastRecord.IdVoucher);
        //    }
        //    else
        //    {
        //        voucher.IdVoucher = autoID("VO000");



        //    }
        //    _voucher.Add(voucher);
        //    _context.SaveChanges();
        //}
        public string autoID(string id)
        {
            //VOXXX
            string result = "";
            int cutID = int.Parse(id.Substring(2, 3));
            cutID++;
            int digits = 3;
            string prefix = "VO";

            // Convert the current ID to string with leading zeros
            string idString = cutID.ToString().PadLeft(digits, '0');
            result = prefix + idString;

            // Combine the prefix and the formatted ID
            return result;

        }


    }
}
