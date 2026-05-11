using Catalog.Application.Responses.ProductCategoryResponse;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Application.Queries.ProductCategoryQuery
{
    public  class GetAllProductCategoryQuery:IRequest<List<GetAllProductCategoryResponse>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
