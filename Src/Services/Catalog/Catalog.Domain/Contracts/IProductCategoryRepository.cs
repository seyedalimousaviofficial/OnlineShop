using Catalog.Domain.Contracts.BaseContract;
using Catalog.Domain.Entities.Products;

namespace Catalog.Domain.Contracts;

public interface IProductCategoryRepository:IBaseRepository<ProductCategory,int>
{
}
