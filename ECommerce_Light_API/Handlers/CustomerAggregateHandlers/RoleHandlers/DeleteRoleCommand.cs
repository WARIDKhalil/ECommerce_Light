using ECommerce_Light_Domain.Shared.CQRS;

namespace ECommerce_Light_API.Handlers.CustomerAggregateHandlers.RoleHandlers
{
    public class DeleteRoleCommand : ICommand<bool>
    {
        public string Id { get; set; }

        public DeleteRoleCommand() { }
    }
}
