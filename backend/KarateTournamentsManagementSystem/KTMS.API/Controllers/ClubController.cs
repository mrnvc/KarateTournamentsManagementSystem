using KTMS.Application.Catalog.Clubs.Commands.AddClub;
using MediatR;
using Microsoft.AspNetCore.Mvc;

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
    }
}
