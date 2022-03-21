﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_Light_Domain.Shared.Mediator
{
    public interface IActionHandler<TAction, TResponse> where TAction : IAction<TResponse>
    {
        Task<TResponse> HandleAsync(TAction action);
    }
}
