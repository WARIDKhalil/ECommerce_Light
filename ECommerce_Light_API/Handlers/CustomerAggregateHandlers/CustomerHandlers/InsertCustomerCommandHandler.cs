using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.CustomerAggregateHandlers.CustomerHandlers
{
    public class InsertCustomerCommandHandler : ICommandHandler<InsertCustomerCommand, Customer>
    {
        private readonly IRepository<Customer, string> _repository;

        public InsertCustomerCommandHandler(IRepository<Customer, string> repository)
        {
            _repository = repository;
        }

        public async Task<Customer> HandleAsync(InsertCustomerCommand action)
        {
            return await _repository.AddAsync(new Customer { FirstName = action.FirstName,
                                                             LastName = action.LastName,
                                                             Birthday = action.Birthday,
                                                             Gender = action.Gender,
                                                             Civility = action.Civility,
                                                             Adress = action.Adress,
                                                             UserState = action.UserState,
                                                             Created = System.DateTime.Now});
        }
    }
}
