using KTMS.Application.Modules.Countries.Dtos;
using MediatR;

namespace KTMS.Application.Modules.Countries.Queries.GetCountries
{
    public class GetCountriesQuery : IRequest<List<CountryDto>>
    {
    }
}
