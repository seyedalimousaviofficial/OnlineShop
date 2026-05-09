using Catalog.Domain.Entities.Common;

namespace Catalog.Domain.Entities.Products
{
    public class ProductBrand : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        #region Relations
        public ICollection<Product> Products { get; set; }
        #endregion
    }
}
