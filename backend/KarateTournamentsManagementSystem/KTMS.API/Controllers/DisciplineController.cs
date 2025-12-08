using KTMS.Application.Modules.Discipline.Query.GetDisciplines;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KTMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplineController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DisciplineController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetDisciplines")]
        public async Task<IActionResult> GetDisciplines(CancellationToken cancellationToken)
        {
            var query = new GetDisciplinesQuery();
            var result = await _mediator.Send(query, cancellationToken);

            return Ok(result);
        }
    }
}
