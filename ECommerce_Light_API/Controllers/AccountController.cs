using ECommerce_Light_API.Handlers.CustomerAggregateHandlers.AccountHandlers;
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
    public class AccountController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Account>> GetAccounts()
        {
            return await _mediator.Send(new GetAccountsQuery());
        }

        [HttpPost]
        public async Task<Account> InsertAccount(InsertAccountCommand action)
        {
            return await _mediator.Send(action);
        }

        [HttpPut]
        public async Task<Account> UpdateAccount(UpdateAccountCommand action)
        {
            return await _mediator.Send(action);
        }

        [HttpDelete]
        public async Task<bool> DeleteAccount(DeleteAccountCommand action)
        {
            return await _mediator.Send(action);
        }
    }
}
