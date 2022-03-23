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
    /// <summary>
    ///     Contains base CRUD-methods
    /// </summary>
    public class MongoRepository<T, TId> : IRepository<T, TId> where T : IBaseEntity<TId>
    {
        protected IMongoCollection<T> _collection;

        public MongoRepository(IDBContext dbContext)
        {
            _collection = (IMongoCollection<T>)dbContext.GetClassifier<T>(typeof(T).Name);
        }

        /// <summary>
        ///     Adding a new object into the collection
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>
        ///     the object inserted
        /// </returns>
        public async Task<T> AddAsync(T entity)
        {
            await _collection.InsertOneAsync(entity);
            return entity;
        }

        /// <summary>
        ///     Look for object and delete it
        ///     The object must exist
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        ///     Status
        /// </returns>
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

        /// <summary>   
        ///     Get all documents of the collection
        /// </summary>
        /// <returns>
        ///     Collection of documents of type T
        /// </returns>
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _collection.Find<T>(_ => true).ToListAsync<T>();
        }

        /// <summary>
        ///     Get a specific document from a collection
        ///     Based on its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        ///     Document of type T
        /// </returns>
        public async Task<T> GetByIdAsync(TId id)
        {
            return await _collection.Find<T>(x => x.Id.Equals(id)).FirstOrDefaultAsync<T>();
        }

        /// <summary>
        ///     Update a whole specific document
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>
        ///     The updated document
        /// </returns>
        public async Task<T> UpdateAsync(T entity)
        {
            await _collection.ReplaceOneAsync<T>(_ => _.Id.Equals(entity.Id), entity);
            return entity;
        }
    }
}
