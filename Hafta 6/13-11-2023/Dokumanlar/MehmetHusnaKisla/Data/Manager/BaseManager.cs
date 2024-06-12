using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Data.Manager
{
    public class BaseManager<TEntity> : ICRUD<TEntity> where TEntity : class
    {
        protected DbSet<TEntity> _dbSet;
        protected Context _context;
        public BaseManager()
        {
            _context = new Context();
            _dbSet = _context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            _dbSet.Remove(GetEntityByID(id));
            _context.SaveChanges();
        }

        public List<TEntity> GetAllEntities(Func<TEntity, bool>? filter = null)
        {
            return filter == null ? _dbSet.ToList() : _dbSet.Where(filter).ToList();
        }

        public List<TEntity> GetAllEntitiesWithJoin(string joinEntityName)
        {
            return _dbSet.Include(joinEntityName).ToList();
        }

        public TEntity GetEntityByID(int id)
        {
            TEntity entity = _dbSet.Find(id);
            _context.Entry(entity).State = EntityState.Detached;
            return entity;
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
