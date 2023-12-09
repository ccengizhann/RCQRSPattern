using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Application.Features.Queries.ProductQueries.Add
{
    public class AddProductRequest: IRequest<AddProductResponse>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
