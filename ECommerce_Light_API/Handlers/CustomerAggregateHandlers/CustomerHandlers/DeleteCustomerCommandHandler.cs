using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.CustomerAggregateHandlers.CustomerHandlers
{
    public class DeleteCustomerCommandHandler : ICommandHandler<DeleteCustomerCommand, bool>
    {
        private readonly IRepository<Customer, string> _repository;

        public DeleteCustomerCommandHandler(IRepository<Customer, string> repository)
        {
            _repository = repository;
        }
        public async Task<bool> HandleAsync(DeleteCustomerCommand action)
        {
            return await _repository.DeleteAsync(action.Id);
        }
    }
}
