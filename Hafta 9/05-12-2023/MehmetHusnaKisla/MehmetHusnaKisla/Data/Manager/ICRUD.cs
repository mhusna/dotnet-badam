using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Data.Manager
{
    public interface ICRUD<TEntity> where TEntity : class
    {
        public void Add(TEntity entity);
        public void Update(TEntity entity);
        public void Delete(int id);
        public TEntity GetEntityByID(int id);
        public List<TEntity> GetAllEntities(Func<TEntity, bool>? filter = null);
        public List<TEntity> GetAllEntitiesWithJoin(string joinEntityName);
    }
}
