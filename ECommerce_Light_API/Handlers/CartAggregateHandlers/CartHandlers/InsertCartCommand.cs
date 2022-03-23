using ECommerce_Light_Domain.Aggregates.Cart.Entities;
using ECommerce_Light_Domain.Shared.CQRS;

namespace ECommerce_Light_API.Handlers.CartAggregateHandlers.CartHandlers
{
    public class InsertCartCommand : ICommand<Cart>
    {
        public string AccountId { get; set; }
        public InsertCartCommand() { }
    }
}
