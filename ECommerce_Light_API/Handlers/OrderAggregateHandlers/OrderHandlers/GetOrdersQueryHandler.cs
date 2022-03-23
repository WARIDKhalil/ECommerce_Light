using ECommerce_Light_Domain.Aggregates.Order.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.OrderAggregateHandlers.OrderHandlers
{
    public class GetOrdersQueryHandler : IQueryHandler<GetOrdersQuery, List<Order>>
    {
        private readonly IRepository<Order, string> _repository;

        public GetOrdersQueryHandler(IRepository<Order, string> repository)
        {
            _repository = repository;
        }
        public async Task<List<Order>> HandleAsync(GetOrdersQuery action)
        {
            return (await _repository.GetAllAsync()).ToList();
        }
    }
}
