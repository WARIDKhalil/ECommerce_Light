using ECommerce_Light_Domain.Shared.CQRS;

namespace ECommerce_Light_API.Handlers.ProductAggregateHandlers.ProductHandlers
{
    public class DeleteProductCommand : ICommand<bool>
    {
        public string Id { get; set; }

        public DeleteProductCommand() { }
    }
}
