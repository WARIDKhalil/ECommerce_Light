using ECommerce_Light_Domain.Shared;
using ECommerce_Light_Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Domain.Aggregates.Cart.Entities
{
    public class Cart : IBaseEntity<string>
    {
        public string Id { get; set; }
        public LineItem[] Items { get; set; }
        public string AccountId { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
