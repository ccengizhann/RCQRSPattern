using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pattern.Application.Features.Queries.CustomerQueries;
using Pattern.Application.Repositories.CustomerRepositories;
using Pattern.Application.Repositories.ProductRepositories;
using Pattern.Domain.Entities;
using Pattern.Persistence.Repositories.CustomerRepositories;
using Pattern.Persistence.Repositories.ProductRepositories;

namespace Pattern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly IMediator _mediator;


        public CustomersController(ICustomerReadRepository customerReadRepository, IMediator mediator)
        {
            _customerReadRepository = customerReadRepository;
            _mediator = mediator;
        }

        [HttpGet("[action]")]
        public List<Customer> GetAll()
        {
            return _customerReadRepository.GetAll();

        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Add(AddCustomerRequest addCustomerRequest)
        {
            var response = _mediator.Send(addCustomerRequest);
            return Ok(response);

        }
    }
}
