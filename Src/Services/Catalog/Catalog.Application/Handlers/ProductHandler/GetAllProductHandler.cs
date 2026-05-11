using Catalog.Application.Queries.Product;
using Catalog.Application.Responses.ProductReponse;
using Catalog.Domain.Contracts;
using MediatR;

namespace Catalog.Application.Handlers.ProductHandler;

public class GetAllProductHandler : IRequestHandler<GetAllProductQuery, List<GetAllProductResponse>>
{
    private readonly IProductRepository _productRepository;

    public GetAllProductHandler(IProductRepository productRepository)
    {
        this._productRepository = productRepository;
    }
    public async Task<List<GetAllProductResponse>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var products = await _productRepository.GetAll(cancellationToken);
            return products.Select(s => (GetAllProductResponse)s).ToList();
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
}
