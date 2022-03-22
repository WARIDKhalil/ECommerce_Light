using ECommerce_Light_Domain.Aggregates.Order.Entities;
using ECommerce_Light_Infrastructure.Abstraction;
using ECommerce_Light_Infrastructure.GenericRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Infrastructure.Repositories
{
    public class OrderRepository : MongoRepository<Order, string>
    {
        public OrderRepository(IDBContext dbContext) 
              : base(dbContext)
        {
        }
    }
}
