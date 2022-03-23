using ECommerce_Light_Domain.Aggregates.Product.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.ProductAggregateHandlers.CategoryHandlers
{
    public class InsertCategoryCommandHandler : ICommandHandler<InsertCategoryCommand, Category>
    {
        private readonly IRepository<Category, string> _repository;

        public InsertCategoryCommandHandler(IRepository<Category, string> repository)
        {
            _repository = repository;
        }
        public async Task<Category> HandleAsync(InsertCategoryCommand action)
        {
            return await _repository.AddAsync(new Category { CategoryName = action.CategoryName,
                                                             Created = System.DateTime.Now });
        }
    }
}
