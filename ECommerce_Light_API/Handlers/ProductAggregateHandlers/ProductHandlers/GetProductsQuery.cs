using ECommerce_Light_Domain.Aggregates.Product.Entities;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Collections.Generic;

namespace ECommerce_Light_API.Handlers.ProductAggregateHandlers.ProductHandlers
{
    public class GetProductsQuery : IQuery<List<Product>>
    {
    }
}
