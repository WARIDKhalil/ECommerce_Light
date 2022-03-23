using ECommerce_Light_Domain.Aggregates.Order.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.OrderAggregateHandlers.OrderHandlers
{
    public class DeleteOrderCommandHandler : ICommandHandler<DeleteOrderCommand, bool>
    {
        private readonly IRepository<Order, string> _repository;

        public DeleteOrderCommandHandler(IRepository<Order, string> repository)
        {
            _repository = repository;
        }
        public async Task<bool> HandleAsync(DeleteOrderCommand action)
        {
            return await _repository.DeleteAsync(action.Id);
        }
    }
}
