using KTMS.Application.Modules.Clubs.Commands.AddClub;
using KTMS.Application.Modules.Clubs.Commands.DeleteClub;
using KTMS.Application.Modules.Clubs.Commands.UpdateClub;
using KTMS.Application.Modules.Clubs.GetClubs.GetClubs;
using KTMS.Application.Modules.Clubs.GetClubs.GetClubsById;
using KTMS.Application.Modules.Users.Queries.GetUsers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Formats.Tar;

namespace KTMS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClubController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClubController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("AddClub")]
        public async Task<IActionResult> AddClub([FromBody] AddClubCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("GetClubs")]
        public async Task<IActionResult> GetClubs()
        {
            var query = new GetClubsQuery();
            var result = await _mediator.Send(query);

            return Ok(result);
        }

        [HttpGet("GetClubsById/{id}")]
        public async Task<IActionResult> GetClubsById(int id)
        {
            var query = new GetClubsByIdQuery(id);

            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPut("UpdateClub")]
        public async Task<IActionResult> UpdateClub(int id, [FromBody] UpdateClubCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("ID does not match");
            }

            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("DeleteClub")]
        public async Task<IActionResult> DeleteClub(int id)
        {
            var command = new DeleteClubCommand { Id = id };

            var result = await _mediator.Send(command);
            return Ok(result);
        }

    }
}
