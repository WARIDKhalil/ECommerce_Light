using ECommerce_Light_Domain.Shared.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Domain.Shared.CQRS
{
    /// <summary>
    ///  Handler of write-actions
    /// </summary>
    /// <typeparam name="TAction">actions of type commmand</typeparam>
    /// <typeparam name="TResponse">return type of Handler</typeparam>
    public interface ICommandHandler<TAction, TResponse> : IActionHandler<TAction, TResponse>
                     where TAction :  ICommand<TResponse>
    {
    }
}
