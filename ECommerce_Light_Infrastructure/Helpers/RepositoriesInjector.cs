using ECommerce_Light_Domain.Aggregates.Cart.Entities;
using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Domain.Aggregates.Order.Entities;
using ECommerce_Light_Domain.Aggregates.Product.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Infrastructure.Helpers
{
    public static class RepositoriesInjector
    {
        /// <summary>
        ///     Extension method to Inject Repositories
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection RepositoryInjector(this IServiceCollection services)
        {
            services.AddSingleton<IRepository<Role, string>, RoleRepository>();
            services.AddSingleton<IRepository<Account, string>, AccountRepository>();
            services.AddSingleton<IRepository<Cart, string>, CartRepository>();
            services.AddSingleton<IRepository<Customer, string>, CustomerRepository>();
            services.AddSingleton<IRepository<Order, string>, OrderRepository>();
            services.AddSingleton<IRepository<Product, string>, ProductRepository>();
            services.AddSingleton<IRepository<Category, string>, CategoryRepository>();
            return services;
        }
    }
}
