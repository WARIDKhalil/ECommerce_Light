using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.CustomerAggregateHandlers.RoleHandlers
{
    public class UpdateRoleCommandHandler : ICommandHandler<UpdateRoleCommand, Role>
    {
        private readonly IRepository<Role, string> _repository;

        public UpdateRoleCommandHandler(IRepository<Role, string> repository)
        {
            _repository = repository;
        }
        public async Task<Role> HandleAsync(UpdateRoleCommand action)
        {
            return await _repository.UpdateAsync(new Role { Id = action.Id, 
                                                            RoleName = action.RoleName,
                                                            Created = action.Created,
                                                            Updated = System.DateTime.Now});
        }
    }
}
