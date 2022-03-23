using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.CustomerAggregateHandlers.AccountHandlers
{
    public class InsertAccountCommandHandler : ICommandHandler<InsertAccountCommand, Account>
    {
        private readonly IRepository<Account, string> _repository;

        public InsertAccountCommandHandler(IRepository<Account, string> repository)
        {
            _repository = repository;
        }
        public async Task<Account> HandleAsync(InsertAccountCommand action)
        {
            return await _repository.AddAsync(new Account { Login = action.Login, 
                                                            Password = action.Password,
                                                            Created = System.DateTime.Now,
                                                            RoleId = action.RoleId});
        }
    }
}
