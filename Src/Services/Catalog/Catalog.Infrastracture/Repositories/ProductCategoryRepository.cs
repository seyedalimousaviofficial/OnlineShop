using Catalog.Domain.Contracts;
using Catalog.Domain.Entities.Products;
using Catalog.Infrastracture.Context;
using Catalog.Infrastracture.Repositories.BaseRepositories;

namespace Catalog.Infrastracture.Repositories;

public class ProductCategoryRepository : BaseRepository<ProductCategory, int>, IProductCategoryRepository
{
    public ProductCategoryRepository(CatalogDbContext dbContext) : base(dbContext)
    {
    }
}
