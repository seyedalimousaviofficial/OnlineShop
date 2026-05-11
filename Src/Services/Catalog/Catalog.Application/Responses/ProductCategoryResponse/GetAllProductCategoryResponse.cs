using Catalog.Domain.Entities.Products;

namespace Catalog.Application.Responses.ProductCategoryResponse;

public class GetAllProductCategoryResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }

    #region Mappers
    public static explicit operator GetAllProductCategoryResponse(ProductCategory input) => new()
    {
        Id = input.Id,
        Name = input.Name,
        CreatedDate = input.CreatedDate,
    };
    #endregion
}
