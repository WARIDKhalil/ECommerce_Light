using ECommerce_Light_Domain.Shared;
using ECommerce_Light_Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Domain.Aggregates.Product.Entities
{
    /// <summary>
    ///  Products in the system
    /// </summary>
    public class Product : IBaseEntity<string>
    {
        public string Id { get; set; }
        public ProductDetails Details { get; set; }
        public string CategoryId { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }

        public Product() { }
    }
}
