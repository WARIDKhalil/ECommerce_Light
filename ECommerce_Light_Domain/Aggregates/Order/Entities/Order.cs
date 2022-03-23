using ECommerce_Light_Domain.Enumerations;
using ECommerce_Light_Domain.Shared;
using ECommerce_Light_Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Domain.Aggregates.Order.Entities
{
    /// <summary>
    ///  Order done by a customer
    /// </summary>
    public class Order : IBaseEntity<string>
    {
        public string Id { get; set; }
        public OrderState State { get; set; }
        public OrderItem[] Items { get; set; }
        public double Total { get; set; }
        public string ApplicantId { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }

        public Order() { }
    }
}
