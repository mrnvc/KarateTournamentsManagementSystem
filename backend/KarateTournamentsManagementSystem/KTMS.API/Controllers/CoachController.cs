using KTMS.Application.Modules.Clubs.Commands.CreateClub;
using KTMS.Application.Modules.Coaches.Commands.CreateCoach;
using KTMS.Application.Modules.Coaches.Commands.DeleteCoach;
using KTMS.Application.Modules.Coaches.Commands.UpdateCoach;
using KTMS.Application.Modules.Coaches.Queries.GetCoaches;
using KTMS.Application.Modules.Coaches.Queries.GetCoachesById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KTMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoachController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CoachController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("CreateCoach")]
        public async Task<IActionResult> CreateCoach([FromBody] CreateCoachCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut("UpdateCoach/{id}")]
        public async Task<IActionResult> UpdateCoach(int id, [FromBody] UpdateCoachCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("ID in URL does not match ID in body.");
            }

            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("DeleteCoach/{id}")]
        public async Task<IActionResult> DeleteCoach(int id)
        {
            var command = new DeleteCoachCommand { Id = id };

            var result = await _mediator.Send(command);

            if (result == default)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet("GetCoaches")]
        public async Task<IActionResult> GetCoaches()
        {
            var query = new GetCoachesQuery(); 
            var result = await _mediator.Send(query);

            return Ok(result);
        }

        [HttpGet("GetCoachById/{id}")]
        public async Task<IActionResult> GetCoachById(int id)
        {
            var query = new GetCoachesByIdQuery(id);

            var result = await _mediator.Send(query);

            return Ok(result);
        }
    }
}
