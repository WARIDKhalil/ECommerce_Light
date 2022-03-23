using ECommerce_Light_Domain.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce_Light_Domain.Repositories
{
    /// <summary>
    ///  Shared contract of basic operations to be handled
    /// </summary>
    /// <typeparam name="T">Entity</typeparam>
    /// <typeparam name="TId"> Id type</typeparam>
    public interface IRepository<T, TId> where T : IBaseEntity<TId>
    {
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetByIdAsync(TId id);
        public Task<T> AddAsync(T entity);
        public Task<T> UpdateAsync(T entity);
        public Task<bool> DeleteAsync(TId id);

    }
}
