using ECommerce_Light_Domain.Shared.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Domain.Shared.CQRS
{
    /// <summary>
    ///  Generic representation of read-Actions
    /// </summary>
    /// <typeparam name="TResponse"> Return type of Query</typeparam>
    public interface IQuery<TResponse> : IAction<TResponse>
    {

    }
}
