using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_Light_Domain.Shared.Mediator
{
    public class Mediator : IMediator
    {
        private readonly Func<Type, object> _serviceResolver;
        private readonly IDictionary<Type, Type> _handlersMapper;

        public Mediator(Func<Type, object> serviceResolver, IDictionary<Type, Type> handlersMapper)
        {
            _serviceResolver = serviceResolver;
            _handlersMapper = handlersMapper;
        }
        public async Task<TResponse> Send<TResponse>(IAction<TResponse> action)
        {
            var actionType = action.GetType();
            if (!_handlersMapper.ContainsKey(actionType))
            {
                throw new Exception($"No Handler for action : {actionType.Name}");
            }
            _handlersMapper.TryGetValue(actionType, out var actionHandlerType);
            var handler = _serviceResolver(actionHandlerType);
            return await (Task<TResponse>)handler.GetType().GetMethod("HandleAsync")
                                          .Invoke(handler, new[] {action});
        }
    }
}
