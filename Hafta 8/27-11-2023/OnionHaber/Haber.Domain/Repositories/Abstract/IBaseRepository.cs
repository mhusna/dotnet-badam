using Haber.Domain.Entities.Abstract;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Haber.Domain.Repositories.Abstract
{
    public interface IBaseRepository<TEntity> where TEntity : class, IBaseEntity
    {
        Task EkleAsync(TEntity entity);
        Task<bool> GuncelleAsync(TEntity entity);
        Task SilAsync(int id);
        Task<IEnumerable<TEntity>> TumKayitlarAsync();
        Task<TEntity> BulAsync(int id);
        Task<IEnumerable<TEntity>> BulAsync(Expression<Func<TEntity, bool>> predicate);

        Task<IEnumerable<TResult>> TumunuFiltreleAsync<TResult>(
            Expression<Func<TEntity, TResult>> select,
            Expression<Func<TEntity, bool>> where,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null
            );

        /*
         Yukarıdaki sorgu kafanı karıştırdıysa bunu kullanabilirsin. IQueryable bize include etme imkanı sunar.
         List, IEnumerable falan kullanımında include atma imkanımız olmaz. Fakat bu kullanımda işlemi bir üst
         katmana aktarır. Ne kadar doğru olduğu tartışmalı bir konu. PL'e aktarmadığımız sürece çok problem değil.
         */
        IQueryable<TEntity> TumunuGetir();
    }
}
