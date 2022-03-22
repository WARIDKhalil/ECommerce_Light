using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Domain.Shared.CQRS;

namespace ECommerce_Light_API.Handlers.CustomerAggregateHandlers.RoleHandlers
{
    public class InsertRoleCommand : ICommand<Role>
    {
        public string RoleName { get; set; }

        public InsertRoleCommand() { }
    }
}
