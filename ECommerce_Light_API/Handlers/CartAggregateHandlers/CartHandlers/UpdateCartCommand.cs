using ECommerce_Light_Domain.Aggregates.Cart.Entities;
using ECommerce_Light_Domain.Shared.CQRS;
using ECommerce_Light_Domain.ValueObjects;
using System;

namespace ECommerce_Light_API.Handlers.CartAggregateHandlers.CartHandlers
{
    public class UpdateCartCommand : ICommand<Cart>
    {
        public string Id { get; set; }
        public LineItem[] Items { get; set; }
        public string AccountId { get; set; }
        public DateTime? Created { get; set; }

        public UpdateCartCommand() { }
    }
}
