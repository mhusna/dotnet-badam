using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I_Tekrar.Data
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int entityID);
        TEntity Find(int entityID);
        List<TEntity> List();
        List<TEntity> ListWithJoin(string kategoriAdi);
        List<TEntity> List(Func<TEntity, bool> predicate);
    }
}
