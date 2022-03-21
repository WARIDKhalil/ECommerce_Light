using ECommerce_Light_Domain.Shared.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Domain.Shared.CQRS
{
    public interface ICommandHandler<TAction, TResponse> : IActionHandler<TAction, TResponse>
                     where TAction :  ICommand<TResponse>
    {
    }
}
