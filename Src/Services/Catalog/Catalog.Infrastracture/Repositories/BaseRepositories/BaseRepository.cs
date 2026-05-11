using Catalog.Domain.Contracts.BaseContract;
using Catalog.Domain.Entities.Common;
using Catalog.Infrastracture.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Catalog.Infrastracture.Repositories.BaseRepositories;

public class BaseRepository<TEntity, TKey>(CatalogDbContext dbContext) : IBaseRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
{
    private DbSet<TEntity> _entity = dbContext.Set<TEntity>();

    public async Task<IEnumerable<TEntity>> GetAll(CancellationToken cancellationToken)
    {
        return await _entity.ToListAsync(cancellationToken);
    }

    public async Task<TEntity> GetById(TKey Id, CancellationToken cancellationToken)
    {
        return await _entity.FindAsync(Id, cancellationToken);
    }

    public async Task<List<TEntity>> GetListByFilter(Expression<Func<TEntity, bool>> predict, CancellationToken cancellationToken)
    {
        return await _entity.Where(predict).ToListAsync(cancellationToken);
    }

    public async Task<List<TEntity>> GetListByFilter(CancellationToken cancellationToken, Expression<Func<TEntity, bool>> predict = null, Expression<Func<TEntity, bool>> OrderBy = null, Expression<Func<TEntity, bool>> OrderByDes = null)
    {
        try
        {
            var query = _entity.AsQueryable();
            if (OrderBy is not null)
                query = query.OrderBy(OrderBy);
            if (OrderByDes is not null)
                query = query.OrderByDescending(OrderByDes);

            return predict is null ?
                await query.ToListAsync(cancellationToken) :
                await query
                .Where(predict)
                .ToListAsync(cancellationToken);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    private IQueryable<TEntity> Incl<TEntity,TProperty>(Expression<Func< IQueryable<TEntity>,TProperty>> query)
    {
        query.in
        return query;
    }
    public async Task<List<TEntity>> GetListByFilter(CancellationToken cancellationToken, Expression<Func<TEntity, bool>> predict = null, Expression<Func<TEntity, bool>> OrderBy = null, Expression<Func<TEntity, bool>> OrderByDes = null,string incs="")
    {
        try
        {

            var query = _entity.AsQueryable();
            if (OrderBy is not null)
                query = query.OrderBy(OrderBy);
            if (OrderByDes is not null)
                query = query.OrderByDescending(OrderByDes);
            query.incl
            return predict is null ?
                await query.ToListAsync(cancellationToken) :
                await query
                .Where(predict)
                .Include(inc)
                .ToListAsync(cancellationToken);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public void Insert(TEntity entity)
    {
        _entity.Add(entity);
    }

    public async Task Save(CancellationToken cancellationToken)
    {
        await dbContext.SaveChangesAsync(cancellationToken);
    }
}
