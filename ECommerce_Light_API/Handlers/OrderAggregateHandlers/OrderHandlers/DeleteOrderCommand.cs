using ECommerce_Light_Domain.Shared.CQRS;

namespace ECommerce_Light_API.Handlers.OrderAggregateHandlers.OrderHandlers
{
    public class DeleteOrderCommand : ICommand<bool>
    {
        public string Id { get; set; }

        public DeleteOrderCommand() { }
    }
}
