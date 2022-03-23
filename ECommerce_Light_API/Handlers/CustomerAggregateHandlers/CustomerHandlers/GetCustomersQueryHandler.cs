using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.CustomerAggregateHandlers.CustomerHandlers
{
    public class GetCustomersQueryHandler : IQueryHandler<GetCustomersQuery, List<Customer>>
    {
        private readonly IRepository<Customer, string> _repository;

        public GetCustomersQueryHandler(IRepository<Customer, string> repository)
        {
            _repository = repository;
        }

        public async Task<List<Customer>> HandleAsync(GetCustomersQuery action)
        {
            return (await _repository.GetAllAsync()).ToList();
        }
    }
}
