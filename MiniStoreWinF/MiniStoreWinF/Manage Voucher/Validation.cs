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


    }
}
