using ECommerce_Light_Domain.Shared.CQRS;

namespace ECommerce_Light_API.Handlers.CustomerAggregateHandlers.CustomerHandlers
{
    public class DeleteCustomerCommand : ICommand<bool>
    {
        public string Id { get; set; }

        public DeleteCustomerCommand() { }
    }
}
