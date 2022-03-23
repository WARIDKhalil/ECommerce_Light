using ECommerce_Light_API.Handlers.CustomerAggregateHandlers.CustomerHandlers;
using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Domain.Shared.Mediator;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Customer>> GetCustomers()
        {
            return await _mediator.Send(new GetCustomersQuery());
        }

        [HttpPost]
        public async Task<Customer> InsertCustomer(InsertCustomerCommand action)
        {
            return await _mediator.Send(action);
        }

        [HttpPut]
        public async Task<Customer> UpdateCustomer(UpdateCustomerCommand action)
        {
            return await _mediator.Send(action);
        }

        [HttpDelete]
        public async Task<bool> DeleteCustomer(DeleteCustomerCommand action)
        {
            return await _mediator.Send(action);
        }
    }
}
