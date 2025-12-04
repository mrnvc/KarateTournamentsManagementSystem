using KTMS.Application.Modules.Countries.Query.GetCountries;
using KTMS.Application.Modules.Countries.Query.GetCountriesById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KTMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CountryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetCountries")]
        public async Task<IActionResult> GetCountries()
        {
            var query = new GetCountriesQuery();

            var result = await _mediator.Send(query);

            return Ok(result);
        }

        [HttpGet("GetCountriesById/{id}")]
        public async Task<IActionResult> GetCountriesById(int id)
        {
            var query = new GetCountriesByIdQuery(id);

            var result = await _mediator.Send(query);

            return Ok(result);
        }
    }
}
