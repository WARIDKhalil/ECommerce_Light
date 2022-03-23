using ECommerce_Light_Domain.Aggregates.Cart.Entities;
using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Domain.Aggregates.Order.Entities;
using ECommerce_Light_Domain.Aggregates.Product.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce_Light_Infrastructure.Mappers
{
    public static class GlobalMapper
    {
        public static IServiceCollection MapAllPOCOs( this IServiceCollection services)
        {
            GenericMapper.MapClass<Role,string>();
            GenericMapper.MapClass<Account, string>();
            GenericMapper.MapRootClass<Person, string>();
            GenericMapper.MapSubClass<Customer, string>();
            GenericMapper.MapClass<Cart, string>();
            GenericMapper.MapClass<Product, string>();
            GenericMapper.MapClass<Category, string>();
            GenericMapper.MapClass<Order, string>();
            return services;
        }

    }
}
