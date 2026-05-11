using Catalog.Domain.Contracts;
using Catalog.Domain.Entities.Products;
using Catalog.Infrastracture.Context;
using Catalog.Infrastracture.Repositories.BaseRepositories;

namespace Catalog.Infrastracture.Repositories;

public class ProductBrandRepository : BaseRepository<ProductBrand, int>, IProductBrandRepository
{
    public ProductBrandRepository(CatalogDbContext dbContext) : base(dbContext)
    {
    }
}
