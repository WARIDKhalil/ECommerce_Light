using ECommerce_Light_Domain.Shared.CQRS;

namespace ECommerce_Light_API.Handlers.CustomerAggregateHandlers.AccountHandlers
{
    public class DeleteAccountCommand : ICommand<bool>
    {
        public string Id { get; set; }

        public DeleteAccountCommand() { }
    }
}
