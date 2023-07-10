using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Service
{
    public class ServiceMiniStore<T>where T : class
    {
        MiniStoreContext _context;
        DbSet<T> _dbset;

        public ServiceMiniStore()
        {
            _context= new MiniStoreContext();
            _dbset = _context.Set<T>();
        }
        public List<T> GetAll()
        {
            return _dbset.ToList();
        }

        public virtual void  Create (T entity)
        {
            _dbset.Add(entity); 
            _context.SaveChanges();
        }

        public bool Delete (T entity)
        {
            _dbset.Remove(entity);
            _context.SaveChanges ();
            return true;
        }
        public void Update (T entity)
        {
            var tracker = _context.Attach(entity);
            tracker.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
