using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.CustomerAggregateHandlers.AccountHandlers
{
    public class GetAccountsQueryHandler : IQueryHandler<GetAccountsQuery, List<Account>>
    {
        private readonly IRepository<Account, string> _repository;

        public GetAccountsQueryHandler(IRepository<Account, string> repository)
        {
            _repository = repository;
        }


        public async Task<List<Account>> HandleAsync(GetAccountsQuery action)
        {
            return (await _repository.GetAllAsync()).ToList();
        }
    }
}
