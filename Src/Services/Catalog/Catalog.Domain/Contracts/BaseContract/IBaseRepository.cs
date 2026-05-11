using Catalog.Domain.Entities.Common;
using System.Linq.Expressions;

namespace Catalog.Domain.Contracts.BaseContract;

public interface IBaseRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
{
    void Insert(TEntity entity);
    Task<TEntity> GetById(TKey Id, CancellationToken cancellationToken);
    Task<IEnumerable<TEntity>> GetAll(CancellationToken cancellationToken);
    Task<List<TEntity>> GetListByFilter(Expression<Func<TEntity, bool>> predict, CancellationToken cancellationToken);
    Task<List<TEntity>> GetListByFilter(CancellationToken cancellationToken,Expression<Func<TEntity, bool>> predict=null, Expression<Func<TEntity, bool>> OrderBy=null, Expression<Func<TEntity, bool>> OrderByDes=null);
    Task Save(CancellationToken cancellationToken);
}
