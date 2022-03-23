using ECommerce_Light_API.Handlers.ProductAggregateHandlers.ProductHandlers;
using ECommerce_Light_Domain.Aggregates.Product.Entities;
using ECommerce_Light_Domain.Shared.Mediator;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Product>> GetProducts()
        {
            return await _mediator.Send(new GetProductsQuery());
        }

        [HttpPost]
        public async Task<Product> InsertProduct(InsertProductCommand action)
        {
            return await _mediator.Send(action);
        }

        [HttpPut]
        public async Task<Product> UpdateProduct(UpdateProductCommand action)
        {
            return await _mediator.Send(action);
        }

        [HttpDelete]
        public async Task<bool> DeleteProduct(DeleteProductCommand action)
        {
            return await _mediator.Send(action);
        }
    }
}
