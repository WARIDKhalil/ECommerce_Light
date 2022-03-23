using ECommerce_Light_Domain.Shared.CQRS;

namespace ECommerce_Light_API.Handlers.CartAggregateHandlers.CartHandlers
{
    public class DeleteCartCommand : ICommand<bool>
    {
        public string Id { get; set; }

        public DeleteCartCommand() { }
    }
}
