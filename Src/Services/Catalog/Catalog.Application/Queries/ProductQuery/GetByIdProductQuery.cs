using Catalog.Application.Responses.ProductReponse;
using MediatR;

namespace Catalog.Application.Queries.Product;

public class GetByIdProductQuery:IRequest<GetByIdProductResponse>
{
    public int Id { get; set; }
}
