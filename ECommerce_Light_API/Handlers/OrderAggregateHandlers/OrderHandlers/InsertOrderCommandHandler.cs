using ECommerce_Light_Domain.Aggregates.Order.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.OrderAggregateHandlers.OrderHandlers
{
    public class InsertOrderCommandHandler : ICommandHandler<InsertOrderCommand, Order>
    {
        private readonly IRepository<Order, string> _repository;

        public InsertOrderCommandHandler(IRepository<Order, string> repository)
        {
            _repository = repository;
        }
        public async Task<Order> HandleAsync(InsertOrderCommand action)
        {
            return await _repository.AddAsync(new Order { ApplicantId = action.ApplicantId,
                                                          State = action.State,
                                                          Total = action.Total,
                                                          Items = action.Items,
                                                          Created = System.DateTime.Now}) ;
        }
    }
}
