using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Domain.Shared.CQRS;

namespace ECommerce_Light_API.Handlers.CustomerAggregateHandlers.AccountHandlers
{
    public class InsertAccountCommand : ICommand<Account>
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string RoleId { get; set; }

        public InsertAccountCommand() { }
    }
}
