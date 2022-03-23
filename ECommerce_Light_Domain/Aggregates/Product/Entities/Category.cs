using ECommerce_Light_Domain.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Domain.Aggregates.Product.Entities
{
    /// <summary>
    ///  Categories of products in the system
    /// </summary>
    public class Category : IBaseEntity<string>
    {
        public string Id { get; set; }
        public string CategoryName { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }

        public Category() { }
    }
}
