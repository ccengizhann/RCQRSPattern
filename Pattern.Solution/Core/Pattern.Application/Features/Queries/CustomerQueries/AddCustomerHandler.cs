using MediatR;
using Pattern.Application.Features.Queries.ProductQueries.Add;
using Pattern.Application.Repositories.CustomerRepositories;
using Pattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pattern.Application.Features.Queries.CustomerQueries
{
    public class AddCustomerHandler : IRequestHandler<AddCustomerRequest, AddCustomerResponse>
    {
        private readonly ICustomerWriteRepository _customerWriteRepository;

        public AddCustomerHandler(ICustomerWriteRepository customerWriteRepository)
        {
            _customerWriteRepository = customerWriteRepository;
        }

        public Task<AddCustomerResponse> Handle(AddCustomerRequest request, CancellationToken cancellationToken)
        {
            var customer = new Customer()
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                PhoneNumber = request.PhoneNumber


            };

            _customerWriteRepository.Add(customer);
            _customerWriteRepository.SaveChanges();

            return Task.FromResult(new AddCustomerResponse());
        }
    }
}
