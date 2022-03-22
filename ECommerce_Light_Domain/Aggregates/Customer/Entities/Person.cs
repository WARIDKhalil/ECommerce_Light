using ECommerce_Light_Domain.Enumerations;
using ECommerce_Light_Domain.Shared;
using ECommerce_Light_Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Domain.Aggregates.Customer.Entities
{
    public class Person : IBaseEntity<string>
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }
        public Civility Civility { get; set; }
        public Adress Adress { get; set; }
        public string AccountId { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }

        public Person() { }

    }
}
