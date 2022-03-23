using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.CustomerAggregateHandlers.AccountHandlers
{
    public class DeleteAccountCommandHandler : ICommandHandler<DeleteAccountCommand, bool>
    {
        private readonly IRepository<Account, string> _repository;
        public DeleteAccountCommandHandler(IRepository<Account, string> repository)
        {
            _repository = repository;
        }
        public async Task<bool> HandleAsync(DeleteAccountCommand action)
        {
            return await _repository.DeleteAsync(action.Id);
        }
    }
}
