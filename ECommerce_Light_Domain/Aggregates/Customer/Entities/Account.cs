using ECommerce_Light_Domain.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Domain.Aggregates.Customer.Entities
{
    /// <summary>
    ///  Account of an user
    /// </summary>
    public class Account : IBaseEntity<string>
    {
        public string Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string OwnerId { get; set; }
        public string RoleId { get; set; }
        public string CartId { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }

        public Account() { }
    }
}
