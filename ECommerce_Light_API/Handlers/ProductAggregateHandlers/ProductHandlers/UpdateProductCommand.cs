using ECommerce_Light_Domain.Aggregates.Product.Entities;
using ECommerce_Light_Domain.Shared.CQRS;
using ECommerce_Light_Domain.ValueObjects;
using System;

namespace ECommerce_Light_API.Handlers.ProductAggregateHandlers.ProductHandlers
{
    public class UpdateProductCommand : ICommand<Product>
    {
        public string Id { get; set; }
        public ProductDetails Details { get; set; }
        public string CategoryId { get; set; }
        public DateTime? Created { get; set; }

        public UpdateProductCommand() { }
    }
}
