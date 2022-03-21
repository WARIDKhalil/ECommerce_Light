using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Domain.Shared.CQRS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.RoleHandlers
{
    public class GetRolesQueryHandler : IQueryHandler<GetRolesQuery, List<Role>>
    {
        public async Task<List<Role>> HandleAsync(GetRolesQuery action)
        {
            return await Task.FromResult(new List<Role>());
        }
    }
}
