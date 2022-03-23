using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Collections.Generic;

namespace ECommerce_Light_API.Handlers.CustomerAggregateHandlers.AccountHandlers
{
    public class GetAccountsQuery : IQuery<List<Account>>
    {

    }
}
