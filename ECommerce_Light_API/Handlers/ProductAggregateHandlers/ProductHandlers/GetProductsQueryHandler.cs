using ECommerce_Light_Domain.Aggregates.Product.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.ProductAggregateHandlers.ProductHandlers
{
    public class GetProductsQueryHandler : IQueryHandler<GetProductsQuery, List<Product>>
    {
        private readonly IRepository<Product, string> _repository;

        public GetProductsQueryHandler(IRepository<Product, string> repository)
        {
            _repository = repository;
        }
        public async Task<List<Product>> HandleAsync(GetProductsQuery action)
        {
            return (await _repository.GetAllAsync()).ToList();
        }
    }
}
