using Catalog.Domain.Entities.Products;

namespace Catalog.Application.Responses.ProductReponse;

public class GetAllProductResponse
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string ShortDescription { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public DateTime CreatedDate { get; set; }
    public int BrandId { get; set; }
    public int CategoryId { get; set; }

    #region explicits

    public static explicit operator GetAllProductResponse(Product input)
    {
        return new GetAllProductResponse()
        {
            CreatedDate = input.CreatedDate,
            Description = input.Description,
            Id = input.Id,
            Price = input.Price,
            ShortDescription = input.ShortDescription,
            Title = input.Title,
            BrandId = input.BrandId,
            CategoryId = input.CategoryId,
        };
    }

    public static explicit operator Domain.Entities.Products.Product(GetAllProductResponse input)
    {
        return new  Product()
        {
            CreatedDate = input.CreatedDate,
            Description = input.Description,
            Price = input.Price,
            ShortDescription = input.ShortDescription,
            Title = input.Title,
            BrandId = input.BrandId,
            CategoryId = input.CategoryId,
        };
    }

    #endregion
}