using ECommerce_Light_Domain.Aggregates.Product.Entities;
using ECommerce_Light_Domain.Shared.CQRS;

namespace ECommerce_Light_API.Handlers.ProductAggregateHandlers.CategoryHandlers
{
    public class InsertCategoryCommand : ICommand<Category>
    {
        public string CategoryName { get; set; }
        public InsertCategoryCommand() { }
    }
}
