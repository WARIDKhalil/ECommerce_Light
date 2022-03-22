using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared;
using ECommerce_Light_Infrastructure.Abstraction;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_Light_Infrastructure.GenericRepositories
{
    public class MongoRepository<T, TId> : IRepository<T, TId> where T : IBaseEntity<TId>
    {
        protected IMongoCollection<T> _collection;

        public MongoRepository(IDBContext dbContext)
        {
            _collection = (IMongoCollection<T>)dbContext.GetClassifier<T>(typeof(T).Name);
        }
        public async Task<T> AddAsync(T entity)
        {
            await _collection.InsertOneAsync(entity);
            return entity;
        }

        public async Task<bool> DeleteAsync(TId id)
        {
            try
            {
                await _collection.DeleteOneAsync(_ => _.Id.Equals(id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _collection.Find<T>(_ => true).ToListAsync<T>();
        }

        public async Task<T> GetByIdAsync(TId id)
        {
            return await _collection.Find<T>(x => x.Id.Equals(id)).FirstOrDefaultAsync<T>();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            await _collection.ReplaceOneAsync<T>(_ => _.Id.Equals(entity.Id), entity);
            return entity;
        }
    }
}
