using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_Light_Domain.Shared.Mediator
{
    /// <summary>
    ///  Shared Behavior of Mediators
    /// </summary>
    public interface IMediator
    {
        Task<TResponse> Send<TResponse>(IAction<TResponse> action);
    }
}
