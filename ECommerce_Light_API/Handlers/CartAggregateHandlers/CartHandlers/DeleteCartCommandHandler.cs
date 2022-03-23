using ECommerce_Light_Domain.Aggregates.Cart.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.CartAggregateHandlers.CartHandlers
{
    public class DeleteCartCommandHandler : ICommandHandler<DeleteCartCommand, bool>
    {
        private readonly IRepository<Cart, string> _repository;

        public DeleteCartCommandHandler(IRepository<Cart, string> repository)
        {
            _repository = repository;
        }
        public async Task<bool> HandleAsync(DeleteCartCommand action)
        {
            return await _repository.DeleteAsync(action.Id);
        }
        
    }
}
