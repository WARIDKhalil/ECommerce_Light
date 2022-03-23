using ECommerce_Light_Domain.Aggregates.Cart.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using ECommerce_Light_Domain.ValueObjects;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.CartAggregateHandlers.CartHandlers
{
    public class InsertCartCommandHandler : ICommandHandler<InsertCartCommand, Cart>
    {
        private readonly IRepository<Cart, string> _repository;

        public InsertCartCommandHandler(IRepository<Cart, string> repository)
        {
            _repository = repository;
        }
        public async Task<Cart> HandleAsync(InsertCartCommand action)
        {
            return await _repository.AddAsync(new Cart { AccountId = action.AccountId,
                                                         Created = System.DateTime.Now });
        }
    }
}
