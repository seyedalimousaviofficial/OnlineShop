using Catalog.Application.Queries.ProductCategoryQuery;
using Catalog.Application.Responses.ProductCategoryResponse;
using Catalog.Domain.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Application.Handlers.ProductCategoryHandler
{
    public class GetAllProductCategoryHandler : IRequestHandler<GetAllProductCategoryQuery, List<GetAllProductCategoryResponse>>
    {
        private readonly IProductCategoryRepository _productCategoryRepository;

        public GetAllProductCategoryHandler(IProductCategoryRepository productCategoryRepository)
        {
            this._productCategoryRepository = productCategoryRepository;
        }
        public async Task<List<GetAllProductCategoryResponse>> Handle(GetAllProductCategoryQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var data =await _productCategoryRepository.GetAll(cancellationToken);
                return data.Select(s => (GetAllProductCategoryResponse)s).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
