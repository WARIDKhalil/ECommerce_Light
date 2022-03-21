using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_Light_Domain.Shared.Mediator
{
    public interface IMediator
    {
        Task<TResponse> Send<TResponse>(IAction<TResponse> action);
    }
}
