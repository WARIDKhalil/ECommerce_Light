using ECommerce_Light_API.Handlers.OrderAggregateHandlers.OrderHandlers;
using ECommerce_Light_Domain.Aggregates.Order.Entities;
using ECommerce_Light_Domain.Shared.Mediator;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Order>> GetOrders()
        {
            return await _mediator.Send(new GetOrdersQuery());
        }

        [HttpPost]
        public async Task<Order> InsertOrder(InsertOrderCommand action)
        {
            return await _mediator.Send(action);
        }

        [HttpPut]
        public async Task<Order> UpdateOrder(UpdateOrderCommand action)
        {
            return await _mediator.Send(action);
        }

        [HttpDelete]
        public async Task<bool> DeleteOrder(DeleteOrderCommand action)
        {
            return await _mediator.Send(action);
        }
    }
}
