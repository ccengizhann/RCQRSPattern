using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pattern.Application.Features.Queries.ProductQueries.Add;
using Pattern.Application.Repositories.ProductRepositories;
using Pattern.Domain.Entities;
using Pattern.Persistence.Contexts;
using Pattern.Persistence.Repositories.ProductRepositories;

namespace Pattern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IMediator _mediator;


        public ProductsController(IProductReadRepository productReadRepository, IMediator mediator)
        {
            _productReadRepository = productReadRepository;
            _mediator = mediator;
        }

        [HttpGet("[action]")]
        public List<Product> GetAll ()
        {
            return _productReadRepository.GetAll();
            
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Add(AddProductRequest addProductRequest)
        {
            var response = await _mediator.Send(addProductRequest);
            return Ok(response);

        }

    }
}
