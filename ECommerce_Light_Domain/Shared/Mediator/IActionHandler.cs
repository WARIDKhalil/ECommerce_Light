using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_Light_Domain.Shared.Mediator
{
    /// <summary>
    ///     Base Handler of an action
    /// </summary>
    /// <typeparam name="TAction">action type : read/write</typeparam>
    /// <typeparam name="TResponse">return type of hadnler</typeparam>
    public interface IActionHandler<TAction, TResponse> where TAction : IAction<TResponse>
    {
        Task<TResponse> HandleAsync(TAction action);
    }
}
