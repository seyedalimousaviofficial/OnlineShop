using Catalog.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Application.Responses.ProductReponse
{
    public class GetByIdProductResponse
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

        public static explicit operator GetByIdProductResponse(Product input)
        {
            return new GetByIdProductResponse()
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

        public static explicit operator Product(GetByIdProductResponse input)
        {
            return new Product()
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
}
