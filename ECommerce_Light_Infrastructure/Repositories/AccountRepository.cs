using ECommerce_Light_Infrastructure.GenericRepositories;
using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ECommerce_Light_Infrastructure.Abstraction;
using MongoDB.Driver;

namespace ECommerce_Light_Infrastructure.Repositories
{
    public class AccountRepository : MongoRepository<Account, string>
    {
        public AccountRepository(IDBContext dbContext) 
               : base(dbContext)
        {

        }

        public async Task<Account> GetAccountByLogin(string login)
        {
            return await _collection.Find<Account>(_ => _.Login == login).FirstOrDefaultAsync();
        }

    }
}
