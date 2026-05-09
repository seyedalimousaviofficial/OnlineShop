using Catalog.Domain.Entities.Common;

namespace Catalog.Domain.Entities.Products
{
    public class ProductCategory : BaseEntity<int>
    {
        public string Name { get; set; }
        #region Relations
        public ICollection<Product> Products { get; set; }
        #endregion
    }
}
