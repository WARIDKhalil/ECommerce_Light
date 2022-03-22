using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.CustmoerAggregateHandlers.RoleHandlers
{
    public class GetRolesQueryHandler : IQueryHandler<GetRolesQuery, List<Role>>
    {
        private readonly IRepository<Role, string> _repository;

        public GetRolesQueryHandler(IRepository<Role,string> repository)
        {
            _repository = repository;
        }
        public async Task<List<Role>> HandleAsync(GetRolesQuery action)
        {
            return (await _repository.GetAllAsync()).ToList<Role>();
        }
    }
}
