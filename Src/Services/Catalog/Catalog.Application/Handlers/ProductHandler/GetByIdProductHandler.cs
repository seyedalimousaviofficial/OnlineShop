using Catalog.Application.Queries.Product;
using Catalog.Application.Responses.ProductReponse;
using Catalog.Domain.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Application.Handlers.Product
{
    public class GetByIdProductHandler : IRequestHandler<GetByIdProductQuery, GetByIdProductResponse>
    {
        private readonly IProductRepository _productRepository;

        public GetByIdProductHandler(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }
        public async Task<GetByIdProductResponse> Handle(GetByIdProductQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var data = await _productRepository.GetById(request.Id, cancellationToken);
                return (GetByIdProductResponse)data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
