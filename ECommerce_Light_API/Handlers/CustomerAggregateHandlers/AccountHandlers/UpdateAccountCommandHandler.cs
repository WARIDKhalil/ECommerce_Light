using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.CustomerAggregateHandlers.AccountHandlers
{
    public class UpdateAccountCommandHandler : ICommandHandler<UpdateAccountCommand, Account>
    {
        private readonly IRepository<Account, string> _repository;

        public UpdateAccountCommandHandler(IRepository<Account, string> repository)
        {
            _repository = repository;
        }


        public async Task<Account> HandleAsync(UpdateAccountCommand action)
        {
            return await _repository.UpdateAsync(new Account { Id = action.Id,
                                                               Login = action.Login,
                                                               Password = action.Password,
                                                               RoleId = action.RoleId,
                                                               OwnerId = action.OwnerId,
                                                               CartId = action.CartId,
                                                               Created = action.Created,
                                                               Updated = System.DateTime.Now});
        }
    }
}
