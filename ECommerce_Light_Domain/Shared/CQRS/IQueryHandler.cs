using ECommerce_Light_Domain.Shared.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Domain.Shared.CQRS
{
    public interface IQueryHandler<TAction,TResponse> : IActionHandler<TAction,TResponse>
                     where TAction : IQuery<TResponse>
    {
    }
}
