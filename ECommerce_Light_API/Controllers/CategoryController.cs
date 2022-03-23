using ECommerce_Light_API.Handlers.ProductAggregateHandlers.CategoryHandlers;
using ECommerce_Light_Domain.Aggregates.Product.Entities;
using ECommerce_Light_Domain.Shared.Mediator;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce_Light_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Category>> GetCategories()
        {
            return await _mediator.Send(new GetCategoriesQuery());
        }

        [HttpPost]
        public async Task<Category> InsertCategory(InsertCategoryCommand action)
        {
            return await _mediator.Send(action);
        }

        [HttpPut]
        public async Task<Category> UpdateCategory(UpdateCategoryCommand action)
        {
            return await _mediator.Send(action);
        }

        [HttpDelete]
        public async Task<bool> DeleteCategory(DeleteCategoryCommand action)
        {
            return await _mediator.Send(action);
        }
    }
}
