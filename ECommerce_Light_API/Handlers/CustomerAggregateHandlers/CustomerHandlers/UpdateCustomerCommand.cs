using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Domain.Enumerations;
using ECommerce_Light_Domain.Shared.CQRS;
using ECommerce_Light_Domain.ValueObjects;
using System;

namespace ECommerce_Light_API.Handlers.CustomerAggregateHandlers.CustomerHandlers
{
    public class UpdateCustomerCommand : ICommand<Customer>
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
        public UserState UserState { get; set; }

        public UpdateCustomerCommand() { }
    }
}
