using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DataAccess
{
    public class EfRepository<T> where T :class
    {
        private DbSet<T> _dbSet;
        private DbContext _context;

        public EfRepository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public void Insert(T entry)
        {
            _context.Entry<T>(entry).State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Update(T entry)
        {
            _context.Entry<T>(entry).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(T entry)
        {
            _context.Entry<T>(entry).State = EntityState.Deleted;
            _context.SaveChanges();
        }

    }
}
