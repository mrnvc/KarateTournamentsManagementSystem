using KTMS.Application.Modules.Belts.Query.GetBelts;
using KTMS.Application.Modules.Belts.Query.GetBeltsById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KTMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeltController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BeltController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetBelts")]
        public async Task<IActionResult> GetBelts(CancellationToken cancellationToken)
        {
            var query = new GetBeltsQuery();
            var result = await _mediator.Send(query, cancellationToken);

            return Ok(result);
        }

        [HttpGet("GetBeltsById/{id}")]
        public async Task<IActionResult> GetBeltsById(int id)
        {
            var query = new GetBeltsByIdQuery(id);
            
            var result = await _mediator.Send(query);

            return Ok(result);
        }
    }
}
