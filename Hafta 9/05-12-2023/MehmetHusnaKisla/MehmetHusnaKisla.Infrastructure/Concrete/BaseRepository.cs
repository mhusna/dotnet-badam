using MehmetHusnaKisla.Domain.Entities.Abstract;
using MehmetHusnaKisla.Domain.Enums;
using MehmetHusnaKisla.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Infrastructure.Concrete
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IBaseEntity
    {
        private readonly Context _context;
        private readonly DbSet<TEntity> _dbSet;

        public BaseRepository(Context context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public async Task DeleteEntity(int id)
        {
            TEntity entity = await GetEntityWithID(id);

            entity.DeleteDate = DateTime.Now;
            entity.RecordStatus = RecordStatus.Passive;

            await UpdateEntity(entity);
        }

        public IQueryable<TEntity> GetAllEntitiesForBeAbleToIncludeEntities()
        {
            return _dbSet.Select(x => x);
        }

        public async Task<IEnumerable<TEntity>> GetAllEntitiesWithFilterAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllEntitiesWithoutFilterAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity> GetEntityWithID(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task InsertEntity(TEntity entity)
        {
            entity.InsertDate = DateTime.Now;
            entity.RecordStatus = RecordStatus.Active;

            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEntity(TEntity entity)
        {
            entity.UpdateDate = DateTime.Now;

            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
