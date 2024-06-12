﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I_Hoca.Data
{
    public class BaseManager<TEntity> : ICRUD<TEntity> where TEntity : class
    {
        private DbSet<TEntity> _dbSet;
        private UrunContext _context;

        public BaseManager()
        {
            _context = new UrunContext();
            _dbSet = _context.Set<TEntity>();
        }

        public TEntity Bul(int entityID)
        {
            var x = _dbSet.Find(entityID);
            _context.Entry(x).State = EntityState.Detached;
            return x;
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

        public List<TEntity> ListeleJoin(string tabloAdi)
        {
            return _dbSet.Include(tabloAdi).ToList();
        }

        public List<TEntity> Listele()
        {
            return _dbSet.ToList();
        }

        public List<TEntity> Listele(Func<TEntity, bool> predicate)
        {
            return _dbSet.Include("Kategori").Where(predicate).ToList();
        }

        public void Sil(int entityID)
        {
            _dbSet.Remove(Bul(entityID));
            _context.SaveChanges();
        }
    }
}
