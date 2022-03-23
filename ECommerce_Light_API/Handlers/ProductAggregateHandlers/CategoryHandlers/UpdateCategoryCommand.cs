using ECommerce_Light_Domain.Aggregates.Product.Entities;
using ECommerce_Light_Domain.Shared.CQRS;
using System;

namespace ECommerce_Light_API.Handlers.ProductAggregateHandlers.CategoryHandlers
{
    public class UpdateCategoryCommand : ICommand<Category>
    {
        public string Id { get; set; }
        public string CategoryName { get; set; }
        public DateTime? Created { get; set; }
        public UpdateCategoryCommand() { }
    }
}
