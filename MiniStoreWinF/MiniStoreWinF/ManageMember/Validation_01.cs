using System;
using Repository.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Repository.Service;

namespace MiniStoreWinF.ManageMember
{
    public class Validation_01 : ServiceMiniStore<Member>
    {
        MiniStoreContext _context;
        DbSet<Member> _member;
        public Validation_01() {
            _context = new MiniStoreContext();
            _member = _context.Set<Member>();
        }
        public List<Member> GetName (string name)
        {
            var records =_member .Where(entity => entity.Name.Contains(name)).ToList();

            return records;
        }

    }
}
