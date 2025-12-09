using KTMS.Application.Modules.Locations.Queries.GetLocations;
using KTMS.Application.Modules.Locations.Queries.GetLocationsById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KTMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LocationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetLocations")]
        public async Task<IActionResult> GetLocations(CancellationToken cancellationToken)
        {
            var query = new GetLocationsQuery();
            var locations = await _mediator.Send(query, cancellationToken);

            return Ok(locations);
        }

        [HttpGet("GetLocationsById/{id}")]
        public async Task<IActionResult> GetLocationsById(int id)
        {
            var query = new GetLocationsByIdQuery(id);
            var locations = await _mediator.Send(query);

            return Ok(locations);
        }
    }
}
