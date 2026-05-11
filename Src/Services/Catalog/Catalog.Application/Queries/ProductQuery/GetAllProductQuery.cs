using Catalog.Application.Responses.ProductReponse;
using MediatR;

namespace Catalog.Application.Queries.Product;

public class GetAllProductQuery:IRequest<List<GetAllProductResponse>>
{
    public string Title { get; set; }
}
