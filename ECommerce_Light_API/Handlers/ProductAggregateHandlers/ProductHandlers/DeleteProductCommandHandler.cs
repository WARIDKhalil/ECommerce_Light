using ECommerce_Light_Domain.Aggregates.Product.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.ProductAggregateHandlers.ProductHandlers
{
    public class DeleteProductCommandHandler : ICommandHandler<DeleteProductCommand, bool>
    {
        private readonly IRepository<Product, string> _repository;

        public DeleteProductCommandHandler(IRepository<Product, string> repository)
        {
            _repository = repository;
        }
        public async Task<bool> HandleAsync(DeleteProductCommand action)
        {
            return await _repository.DeleteAsync(action.Id);
        }
    }
}
