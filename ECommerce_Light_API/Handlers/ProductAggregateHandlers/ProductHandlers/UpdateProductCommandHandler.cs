using ECommerce_Light_Domain.Aggregates.Product.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using ECommerce_Light_Domain.ValueObjects;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.ProductAggregateHandlers.ProductHandlers
{
    public class UpdateProductCommandHandler : ICommandHandler<UpdateProductCommand, Product>
    {
        private readonly IRepository<Product, string> _repository;

        public UpdateProductCommandHandler(IRepository<Product, string> repository)
        {
            _repository = repository;
        }
        public async Task<Product> HandleAsync(UpdateProductCommand action)
        {
            return await _repository.UpdateAsync(new Product { Id = action.Id,
                                                               Details = action.Details,
                                                               CategoryId = action.CategoryId,
                                                               Created = action.Created,
                                                               Updated = System.DateTime.Now});
        }
    }
}
