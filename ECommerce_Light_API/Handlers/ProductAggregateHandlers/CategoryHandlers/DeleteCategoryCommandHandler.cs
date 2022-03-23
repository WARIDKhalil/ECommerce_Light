using ECommerce_Light_Domain.Aggregates.Product.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.ProductAggregateHandlers.CategoryHandlers
{
    public class DeleteCategoryCommandHandler : ICommandHandler<DeleteCategoryCommand, bool>
    {
        private readonly IRepository<Category, string> _repository;

        public DeleteCategoryCommandHandler(IRepository<Category, string> repository)
        {
            _repository = repository;
        }
        public async Task<bool> HandleAsync(DeleteCategoryCommand action)
        {
            return await _repository.DeleteAsync(action.Id);
        }
    }
}
