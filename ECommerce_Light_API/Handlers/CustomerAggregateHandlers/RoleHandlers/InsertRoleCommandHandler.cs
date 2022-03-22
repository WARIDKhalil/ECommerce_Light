using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.CustomerAggregateHandlers.RoleHandlers
{
    public class InsertRoleCommandHandler : ICommandHandler<InsertRoleCommand, Role>
    {
        private readonly IRepository<Role, string> _repository;

        public InsertRoleCommandHandler(IRepository<Role, string> repository)
        {
            _repository = repository;
        }
        public async Task<Role> HandleAsync(InsertRoleCommand action)
        {

            return await _repository.AddAsync(
                new Role { RoleName = action.RoleName,
                           Created = System.DateTime.Now
            });
        }
    }
}
