using ECommerce_Light_Domain.Shared.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Domain.Shared.CQRS
{
    /// <summary>
    ///     Handler of read-actions
    /// </summary>
    /// <typeparam name="TAction">actions of type Query</typeparam>
    /// <typeparam name="TResponse">return type of handler</typeparam>
    public interface IQueryHandler<TAction,TResponse> : IActionHandler<TAction,TResponse>
                     where TAction : IQuery<TResponse>
    {
    }
}
