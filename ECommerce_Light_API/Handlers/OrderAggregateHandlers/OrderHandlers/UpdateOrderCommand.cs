using ECommerce_Light_Domain.Aggregates.Order.Entities;
using ECommerce_Light_Domain.Enumerations;
using ECommerce_Light_Domain.Shared.CQRS;
using ECommerce_Light_Domain.ValueObjects;
using System;

namespace ECommerce_Light_API.Handlers.OrderAggregateHandlers.OrderHandlers
{
    public class UpdateOrderCommand : ICommand<Order>
    {
        public string Id { get; set; }
        public OrderState State { get; set; }
        public OrderItem[] Items { get; set; }
        public double Total { get; set; }
        public string ApplicantId { get; set; }
        public DateTime? Created { get; set; }

        public UpdateOrderCommand() { }
    }
}
