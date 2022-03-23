using ECommerce_Light_Domain.Aggregates.Cart.Entities;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Collections.Generic;

namespace ECommerce_Light_API.Handlers.CartAggregateHandlers.CartHandlers
{
    public class GetCartsQuery : IQuery<List<Cart>>
    {
    }
}
