using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Interview.CartCase.Domain.Entities;

namespace Interview.CartCase.Domain.Interfaces
{
    public interface IBaseRepository<TEntity, TId> where TEntity : class, IEntity<TId>, new()
                                                   where TId : IEquatable<TId>
    {
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter);
        Task<IEnumerable<TEntity>> GetManyAsync(Expression<Func<TEntity, bool>> filter = null);
        Task InsertAsync(TEntity entity);
        Task InsertAsync(IEnumerable<TEntity> entities);
        Task UpdateAsync(TEntity entity);
        Task UpdateAsync(IEnumerable<TEntity> entities);
        Task DeleteAsync(TEntity entity);
        Task DeleteAsync(IEnumerable<TEntity> entities);
    }
}