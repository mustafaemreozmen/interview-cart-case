using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Interview.CartCase.Domain.Interfaces
{
    public interface IBaseRepository<TEntity, TId> where TEntity : class, IEntity<TId>, new()
                                                   where TId : IEquatable<TId>
    {
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter);
        Task<IEnumerable<TEntity>> GetManyAsync(Expression<Func<TEntity, bool>> filter = null);
        Task<TEntity> InsertAsync(TEntity entity);
        Task<IEnumerable<TEntity>> InsertAsync(IEnumerable<TEntity> entities);
        Task<TEntity> UpdateAsync(string id, TEntity entity);
        Task<IEnumerable<TEntity>> UpdateAsync(IEnumerable<TEntity> entities);
        Task<TEntity> DeleteAsync(TId id);
        Task<TEntity> DeleteAsync(TEntity entity);
        Task<IEnumerable<TEntity>> DeleteAsync(IEnumerable<TEntity> entities);
    }
}