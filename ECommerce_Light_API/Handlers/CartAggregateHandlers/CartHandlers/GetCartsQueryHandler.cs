using ECommerce_Light_Domain.Aggregates.Cart.Entities;
using ECommerce_Light_Domain.Repositories;
using ECommerce_Light_Domain.Shared.CQRS;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Handlers.CartAggregateHandlers.CartHandlers
{
    public class GetCartsQueryHandler : IQueryHandler<GetCartsQuery, List<Cart>>
    {
        private readonly IRepository<Cart, string> _repository;

        public GetCartsQueryHandler(IRepository<Cart, string> repository)
        {
            _repository = repository;
        }
        public async Task<List<Cart>> HandleAsync(GetCartsQuery action)
        {
            return (await _repository.GetAllAsync()).ToList();
        }
    }
}
