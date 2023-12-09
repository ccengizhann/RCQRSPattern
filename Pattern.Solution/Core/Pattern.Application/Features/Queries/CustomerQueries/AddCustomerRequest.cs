using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Application.Features.Queries.CustomerQueries
{
    public class AddCustomerRequest:IRequest<AddCustomerResponse>
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
