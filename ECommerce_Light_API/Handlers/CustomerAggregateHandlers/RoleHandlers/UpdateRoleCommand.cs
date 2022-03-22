using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Domain.Shared.CQRS;
using System;

namespace ECommerce_Light_API.Handlers.CustomerAggregateHandlers.RoleHandlers
{
    public class UpdateRoleCommand : ICommand<Role>
    {
        public string Id { get; set; }
        public string RoleName { get; set; }
        public DateTime Created { get; set; }

        public UpdateRoleCommand() { }
    }
}
