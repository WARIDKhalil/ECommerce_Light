using ECommerce_Light_API.Handlers.CustmoerAggregateHandlers.RoleHandlers;
using ECommerce_Light_API.Handlers.CustomerAggregateHandlers.RoleHandlers;
using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Domain.Shared.Mediator;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RoleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Role>> GetRoles()
        {
            return await _mediator.Send(new GetRolesQuery());
        }

        [HttpPost]
        public async Task<Role> InsertRole(InsertRoleCommand action)
        {
            return await _mediator.Send(action);
        }

        [HttpPut]
        public async Task<Role> UpdateRole(UpdateRoleCommand action)
        {
            return await _mediator.Send(action);
        }

        [HttpDelete]
        public async Task<bool> DeleteRole(DeleteRoleCommand action)
        {
            return await _mediator.Send(action);
        }

    }
}
