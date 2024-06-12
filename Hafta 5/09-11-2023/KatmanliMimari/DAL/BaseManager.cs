using DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BaseManager<TEntity> : ICRUD<TEntity> where TEntity : class
    {
        Context _context;
        DbSet<TEntity> _table;
        public BaseManager()
        {
            _context = new Context();
            _table = _context.Set<TEntity>();
        }

        public TEntity Bul(int id)
        {
            TEntity entity = _table.Find(id);
            _context.Entry(entity).State = EntityState.Detached;
            return entity;
        }

        public void Ekle(TEntity entity)
        {
            _table.Add(entity);
            _context.SaveChanges();
        }

        public void Guncelle(TEntity entity)
        {
            // Bazen etkisiz kalabiliyor.
            // _table.Update(entity);

            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Sil(int id)
        {
            _table.Remove(Bul(id));
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> Tumu(Func<TEntity, bool> predicate = null)
        {
            return predicate == null ? _table.ToList() : _table.Where(predicate).ToList();
        }
    }
}
