using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Infrastructure.Abstraction;
using ECommerce_Light_Infrastructure.GenericRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Infrastructure.Repositories
{
    public class CustomerRepository : MongoRepository<Customer, string>
    {
        public CustomerRepository(IDBContext dbContext) 
               : base(dbContext)
        {
        }
    }
}
