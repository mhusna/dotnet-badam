using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Data.Manager
{
    public class BaseManager<TEntity> : ICRUD<TEntity> where TEntity : class
    {
        protected Context _context;
        protected DbSet<TEntity> _dbSet;
        public BaseManager()
        {
            _context = new Context();
            _dbSet = _context.Set<TEntity>();
        }

        public TEntity Bul(int id)
        {
            TEntity? entity = _dbSet.Find(id);

            if (entity != null)
            {
                _context.Entry(entity).State = EntityState.Detached;
                return entity;
            }
            else
                return null;
            
        }

        public void Ekle(TEntity entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Guncelle(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> Listele(Func<TEntity, bool> predicate = null)
        {
            return predicate == null ? _dbSet.ToList() : _dbSet.Where(predicate).ToList();
        }

        public void Sil(int id)
        {
            _dbSet.Remove(Bul(id));
            _context.SaveChanges();
        }
    }
}
