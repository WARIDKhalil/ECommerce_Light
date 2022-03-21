using ECommerce_Light_Domain.Shared.CQRS;
using ECommerce_Light_Domain.Shared.Mediator;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ECommerce_Light_API.DependencyInjection
{
    public static class ServiceCollectionExtentions
    {
        public static IServiceCollection AddMediator(
                        this IServiceCollection services,
                        ServiceLifetime lifetime,
                        params Type[] markers)
        {
            var handlerMapper = new Dictionary<Type, Type>();
            foreach (var marker in markers)
            {
                var assembly = marker.Assembly;
                var actions = GetClassesImplementingInterface(assembly, typeof(IAction<>));
                var handlers = GetClassesImplementingInterface(assembly, typeof(IActionHandler<,>));
                actions.ForEach(action =>
                {
                    handlerMapper[action] = handlers.SingleOrDefault( 
                        handler => action == handler.GetInterface("IActionHandler`2").GetGenericArguments()[0]);
                });
                var serviceDescriptor = handlers.Select(x => new ServiceDescriptor(x, x, lifetime));
                services.TryAdd(serviceDescriptor);
            }
            services.AddSingleton<IMediator>(x => new Mediator(x.GetRequiredService, handlerMapper));
            return services;
        }

        private static List<Type> GetClassesImplementingInterface(Assembly assembly, Type typeToMatch)
        {
            return assembly.ExportedTypes.Where(type =>
                   {
                        var genericInterfaceTypes = type.GetInterfaces().Where(x => x.IsGenericType);
                        var implementActionType = genericInterfaceTypes
                                                  .Any(x => x.GetGenericTypeDefinition() == typeToMatch);
                        return !type.IsInterface && !type.IsAbstract && implementActionType;
                   }).ToList();
        }
    }
}
