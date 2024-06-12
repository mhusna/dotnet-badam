using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Data.Manager
{
    public interface ICRUD<TEntity> where TEntity : class
    {
        void Ekle(TEntity entity);
        void Sil(int id);
        TEntity Bul(int id);
        void Guncelle(TEntity entity);
        IEnumerable<TEntity> Listele(Func<TEntity, bool> predicate = null);
    }
}
