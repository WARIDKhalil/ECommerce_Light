using ECommerce_Light_Domain.Aggregates.Customer.Entities;
using ECommerce_Light_Infrastructure.Abstraction;
using ECommerce_Light_Infrastructure.GenericRepositories;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_Light_Infrastructure.Repositories
{
    public class RoleRepository : MongoRepository<Role, string>
    {
        public RoleRepository(IDBContext dbContext) 
            : base(dbContext)
        {

        }

        public async Task<Role> GetRoleByName(string roleName)
        {
            return await _collection.Find<Role>(_ => _.RoleName == roleName)
                                    .FirstOrDefaultAsync<Role>();        
        }
    }
}
