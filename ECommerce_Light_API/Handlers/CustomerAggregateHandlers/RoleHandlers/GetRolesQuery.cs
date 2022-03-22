using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Domain.Shared.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_API.Handlers.CustmoerAggregateHandlers.RoleHandlers
{
    public class GetRolesQuery : IQuery<List<Role>>
    {

    }
}
