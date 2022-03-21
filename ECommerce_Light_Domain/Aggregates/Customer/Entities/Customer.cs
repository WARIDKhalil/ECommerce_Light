using ECommerce_Light_Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Domain.Aggregates.Customer.Entities
{
    public class Customer : Person
    {
        public UserState UserState { get; set; }

        public Customer() : base() { }
    }
}
