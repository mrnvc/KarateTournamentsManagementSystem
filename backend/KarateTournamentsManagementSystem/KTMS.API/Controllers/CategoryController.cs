using KTMS.Application.Modules.Categories.Query.GetCategories;
using KTMS.Application.Modules.Categories.Query.GetCategoriesById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KTMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetCategories")]
        public async Task<IActionResult> GetCategories(CancellationToken cancellationToken)
        {
            var query = new GetCategoriesQuery();
            var result = await _mediator.Send(query, cancellationToken);

            return Ok(result);
        }

        [HttpGet("GetCategoriesById/{id}")]
        public async Task<IActionResult> GetCategoriesById(int id)
        {
            var query = new GetCategoriesByIdQuery(id);
            var result = await _mediator.Send(query);

            return Ok(result);
        }
    }
}
