using ECommerce_Light_Domain.Aggregates.Order.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.OrderAggregateHandlers.OrderHandlers
{
    public class UpdateOrderCommandHandler : ICommandHandler<UpdateOrderCommand, Order>
    {
        private readonly IRepository<Order, string> _repository;

        public UpdateOrderCommandHandler(IRepository<Order, string> repository)
        {
            _repository = repository;
        }
        public async Task<Order> HandleAsync(UpdateOrderCommand action)
        {
            return await _repository.UpdateAsync(new Order {   Id = action.Id,
                                                               State = action.State,
                                                               ApplicantId = action.ApplicantId,
                                                               Total = action.Total,
                                                               Items = action.Items,
                                                               Created = action.Created,
                                                               Updated = System.DateTime.Now });
        }
    }
}
