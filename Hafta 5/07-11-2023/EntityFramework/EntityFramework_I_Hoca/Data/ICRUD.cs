using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I_Hoca.Data
{
    public interface ICRUD<TEntity> where TEntity : class
    {
        void Ekle(TEntity entity);
        void Guncelle(TEntity entity);
        void Sil(int entityID);
        List<TEntity> Listele();
        List<TEntity> ListeleJoin(string tabloAdi);
        TEntity Bul(int entityID);
        List<TEntity> Listele(Func<TEntity, bool> predicate);
    }
}
