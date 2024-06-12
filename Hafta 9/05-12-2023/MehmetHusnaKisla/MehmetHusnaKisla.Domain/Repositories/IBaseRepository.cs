using MehmetHusnaKisla.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Domain.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class, IBaseEntity
    {
        Task InsertEntity(TEntity entity);
        Task<TEntity> GetEntityWithID(int id);
        Task<IEnumerable<TEntity>> GetAllEntitiesWithoutFilterAsync();
        Task<IEnumerable<TEntity>> GetAllEntitiesWithFilterAsync(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> GetAllEntitiesForBeAbleToIncludeEntities();

        Task UpdateEntity(TEntity entity);
        Task DeleteEntity(int id);
    }
}
