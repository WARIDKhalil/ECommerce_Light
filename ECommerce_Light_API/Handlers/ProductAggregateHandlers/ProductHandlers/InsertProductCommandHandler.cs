using ECommerce_Light_Domain.Aggregates.Product.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using ECommerce_Light_Domain.ValueObjects;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.ProductAggregateHandlers.ProductHandlers
{
    public class InsertProductCommandHandler : ICommandHandler<InsertProductCommand, Product>
    {
        private readonly IRepository<Product, string> _repository;

        public InsertProductCommandHandler(IRepository<Product, string> repository)
        {
            _repository = repository;
        }
        public async Task<Product> HandleAsync(InsertProductCommand action)
        {
            return await _repository.AddAsync(new Product { Details = action.Details,
                                                            CategoryId = action.CategoryId,
                                                            Created = System.DateTime.Now});
        }
    }
}
