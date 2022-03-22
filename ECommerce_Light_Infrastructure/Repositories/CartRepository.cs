using ECommerce_Light_Domain.Aggregates.Cart.Entities;
using ECommerce_Light_Infrastructure.Abstraction;
using ECommerce_Light_Infrastructure.GenericRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Infrastructure.Repositories
{
    public class CartRepository : MongoRepository<Cart, string>
    {
        public CartRepository(IDBContext dbContext) 
               : base(dbContext)
        {
        }
    }
}
