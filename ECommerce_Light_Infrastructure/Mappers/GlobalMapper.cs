using ECommerce_Light_Domain.Aggregates.Cart.Entities;
using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Domain.Aggregates.Order.Entities;
using ECommerce_Light_Domain.Aggregates.Product.Entities;
using ECommerce_Light_Domain.Shared;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ECommerce_Light_Infrastructure.Mappers
{
    public static class GlobalMapper
    {
        public static IServiceCollection MapAllPOCOs( this IServiceCollection services)
        {
            var Mapper = new GenericMapper();
            Mapper.MapClass<Role,string>();
            Mapper.MapClass<Account, string>();
            Mapper.MapRootClass<Person, string>();
            Mapper.MapSubClass<Customer, string>();
            Mapper.MapClass<Cart, string>();
            Mapper.MapClass<Product, string>();
            Mapper.MapClass<Category, string>();
            Mapper.MapClass<Order, string>();
            return services;
        }

    }
}
