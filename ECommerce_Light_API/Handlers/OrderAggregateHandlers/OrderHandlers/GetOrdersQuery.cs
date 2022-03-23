using ECommerce_Light_Domain.Aggregates.Order.Entities;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Collections.Generic;

namespace ECommerce_Light_API.Handlers.OrderAggregateHandlers.OrderHandlers
{
    public class GetOrdersQuery : IQuery<List<Order>>
    {
    }
}
