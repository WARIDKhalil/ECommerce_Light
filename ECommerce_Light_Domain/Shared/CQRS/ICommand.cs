using ECommerce_Light_Domain.Shared.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Domain.Shared.CQRS
{
    /// <summary>
    ///   Generic representation of write-Actions
    /// </summary>
    /// <typeparam name="TResponse"> Return type of command</typeparam>
    public interface ICommand<TResponse> : IAction<TResponse>
    {

    }
}
