using ECommerce_Light_Domain.Aggregates.Product.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.ProductAggregateHandlers.CategoryHandlers
{
    public class GetCategoriesQueryHandler : IQueryHandler<GetCategoriesQuery, List<Category>>
    {
        private readonly IRepository<Category, string> _repository;

        public GetCategoriesQueryHandler(IRepository<Category, string> repository)
        {
            _repository = repository;
        }
        public async Task<List<Category>> HandleAsync(GetCategoriesQuery action)
        {
            return (await _repository.GetAllAsync()).ToList();
        }
    }
}
