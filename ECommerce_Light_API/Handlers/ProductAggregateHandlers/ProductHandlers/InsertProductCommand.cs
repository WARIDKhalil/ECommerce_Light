using ECommerce_Light_Domain.Aggregates.Product.Entities;
using ECommerce_Light_Domain.Shared.CQRS;
using ECommerce_Light_Domain.ValueObjects;

namespace ECommerce_Light_API.Handlers.ProductAggregateHandlers.ProductHandlers
{
    public class InsertProductCommand : ICommand<Product>
    {
        public ProductDetails Details { get; set; }
        public string CategoryId { get; set; }
        public InsertProductCommand() { }
    }
}
