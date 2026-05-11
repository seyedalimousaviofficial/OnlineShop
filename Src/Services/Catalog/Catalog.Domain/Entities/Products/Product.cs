using Catalog.Domain.Entities.Common;

namespace Catalog.Domain.Entities.Products;

public class Product : BaseEntity<int>
{
    public string Title { get; set; }
    public string ShortDescription { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

    #region ForignKeys
    public int BrandId { get; set; }
    public int CategoryId { get; set; }
    #endregion
    #region Relations
    public ProductBrand Brands { get; set; }
    public ProductCategory Categories { get; set; }
    #endregion
}
