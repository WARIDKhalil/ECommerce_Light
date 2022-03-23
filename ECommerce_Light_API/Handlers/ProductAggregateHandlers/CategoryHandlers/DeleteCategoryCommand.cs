using ECommerce_Light_Domain.Shared.CQRS;

namespace ECommerce_Light_API.Handlers.ProductAggregateHandlers.CategoryHandlers
{
    public class DeleteCategoryCommand : ICommand<bool>
    {
        public string Id { get; set; }

        public DeleteCategoryCommand() { }
    }
}
