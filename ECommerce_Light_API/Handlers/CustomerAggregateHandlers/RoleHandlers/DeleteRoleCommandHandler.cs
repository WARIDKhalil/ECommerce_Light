using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.CustomerAggregateHandlers.RoleHandlers
{
    public class DeleteRoleCommandHandler : ICommandHandler<DeleteRoleCommand, bool>
    {
        private readonly IRepository<Role, string> _repository;

        public DeleteRoleCommandHandler(IRepository<Role, string> repository)
        {
            _repository = repository;
        }

        public async Task<bool> HandleAsync(DeleteRoleCommand action)
        {
            return await _repository.DeleteAsync(action.Id);
        }
    }
}
