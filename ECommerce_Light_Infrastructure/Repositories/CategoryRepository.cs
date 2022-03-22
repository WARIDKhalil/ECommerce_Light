using ECommerce_Light_Domain.Aggregates.Product.Entities;
using ECommerce_Light_Infrastructure.Abstraction;
using ECommerce_Light_Infrastructure.GenericRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Infrastructure.Repositories
{
    public class CategoryRepository : MongoRepository<Category, string>
    {
        public CategoryRepository(IDBContext dbContext) 
               : base(dbContext)
        {
        }
    }
}
