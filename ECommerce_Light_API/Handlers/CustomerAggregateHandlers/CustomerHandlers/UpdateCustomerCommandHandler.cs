using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.CustomerAggregateHandlers.CustomerHandlers
{
    public class UpdateCustomerCommandHandler : ICommandHandler<UpdateCustomerCommand, Customer>
    {
        private readonly IRepository<Customer, string> _repository;

        public UpdateCustomerCommandHandler(IRepository<Customer, string> repository)
        {
            _repository = repository;
        }

        public async Task<Customer> HandleAsync(UpdateCustomerCommand action)
        {
            return await _repository.UpdateAsync(new Customer
            {   Id = action.Id,
                FirstName = action.FirstName,
                LastName = action.LastName,
                Birthday = action.Birthday,
                Gender = action.Gender,
                Civility = action.Civility,
                Adress = action.Adress,
                UserState = action.UserState,
                Created = action.Created,
                AccountId = action.AccountId,
                Updated = System.DateTime.Now
            });
        }
    }
}
