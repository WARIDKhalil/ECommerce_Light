using ECommerce_Light_Domain.Aggregates.Product.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.ProductAggregateHandlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler : ICommandHandler<UpdateCategoryCommand, Category>
    {
        private readonly IRepository<Category, string> _repository;

        public UpdateCategoryCommandHandler(IRepository<Category, string> repository)
        {
            _repository = repository;
        }
        public async Task<Category> HandleAsync(UpdateCategoryCommand action)
        {
            return await _repository.UpdateAsync(new Category { Id = action.Id,
                                                                CategoryName = action.CategoryName,
                                                                Created = action.Created,
                                                                Updated = System.DateTime.Now});
        }
    }
}
