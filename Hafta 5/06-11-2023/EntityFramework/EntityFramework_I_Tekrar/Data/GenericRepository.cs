using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I_Tekrar.Data
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private DbSet<TEntity> _dbSet;
        private Context _context;

        public GenericRepository()
        {
            _context = new Context();
            _dbSet = _context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int entityID)
        {
            _dbSet.Remove(Find(entityID));
            _context.SaveChanges();
        }

        public TEntity Find(int entityID)
        {
            return _dbSet.Find(entityID);
        }

        public List<TEntity> List()
        {
            return _dbSet.ToList();
        }

        public List<TEntity> List(Func<TEntity, bool> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }

        public List<TEntity> ListWithJoin(string kategoriAdi)
        {
            return _dbSet.Include(kategoriAdi).ToList();
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
