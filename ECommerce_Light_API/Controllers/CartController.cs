using ECommerce_Light_API.Handlers.CartAggregateHandlers.CartHandlers;
using ECommerce_Light_Domain.Aggregates.Cart.Entities;
using ECommerce_Light_Domain.Shared.Mediator;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CartController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Cart>> GetCarts()
        {
            return await _mediator.Send(new GetCartsQuery());
        }

        [HttpPost]
        public async Task<Cart> InsertCart(InsertCartCommand action)
        {
            return await _mediator.Send(action);
        }

        [HttpPut]
        public async Task<Cart> UpdateCart(UpdateCartCommand action)
        {
            return await _mediator.Send(action);
        }

        [HttpDelete]
        public async Task<bool> DeleteCart(DeleteCartCommand action)
        {
            return await _mediator.Send(action);
        }
    }
}
