using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_Light_Domain.Shared.Mediator
{
    /// <summary>
    ///  Concrete mediator, handles comming requests (actions) 
    ///  and deliver them to the right handler
    /// </summary>
    public class Mediator : IMediator
    {
        /// <summary>
        ///  Get appropiate handler based on its type
        /// </summary>
        private readonly Func<Type, object> _serviceResolver;
        /// <summary>
        ///  Maps every action with its handler
        /// </summary>
        private readonly IDictionary<Type, Type> _handlersMapper;

        public Mediator(Func<Type, object> serviceResolver, IDictionary<Type, Type> handlersMapper)
        {
            _serviceResolver = serviceResolver;
            _handlersMapper = handlersMapper;
        }
        /// <summary>
        ///     Takes an action,
        ///     looks for appropriate handler,
        ///     Invoke the handler,
        ///     Get the response
        /// </summary>
        /// <typeparam name="TResponse"> return type of action</typeparam>
        /// <param name="action"></param>
        /// <returns>response from handler</returns>
        /// <exception cref="Exception">ActionType does not exist in registry</exception>
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
