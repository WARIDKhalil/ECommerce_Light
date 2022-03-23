using ECommerce_Light_Domain.Aggregates.Product.Entities;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Collections.Generic;

namespace ECommerce_Light_API.Handlers.ProductAggregateHandlers.CategoryHandlers
{
    public class GetCategoriesQuery : IQuery<List<Category>>
    {
    }
}
