using ECommerce_Light_Domain.Aggregates.Cart.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.CartAggregateHandlers.CartHandlers
{
    public class UpdateCartCommandHandler : ICommandHandler<UpdateCartCommand, Cart>
    {
        private readonly IRepository<Cart, string> _repository;

        public UpdateCartCommandHandler(IRepository<Cart, string> repository)
        {
            _repository = repository;
        }
        public async Task<Cart> HandleAsync(UpdateCartCommand action)
        {
            return await _repository.UpdateAsync(new Cart { Id = action.Id,
                                                            Items = action.Items,
                                                            AccountId = action.AccountId,
                                                            Created = action.Created,
                                                            Updated = System.DateTime.Now});
        }
    }
}
