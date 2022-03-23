using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Domain.Shared.CQRS;
using System;

namespace ECommerce_Light_API.Handlers.CustomerAggregateHandlers.AccountHandlers
{
    public class UpdateAccountCommand : ICommand<Account>
    {
        public string Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string OwnerId { get; set; }
        public string RoleId { get; set; }
        public string CartId { get; set; }
        public DateTime? Created { get; set; }

        public UpdateAccountCommand() { }
    }
}
