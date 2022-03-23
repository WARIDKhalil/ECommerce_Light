using ECommerce_Light_Domain.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Domain.Aggregates.Customer.Entities
{
    /// <summary>
    ///   Represents the roles in the system
    /// </summary>
    public class Role : IBaseEntity<string>
    {
        public string Id { get; set; }
        public string RoleName { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }

        public Role() { }
    }
}
