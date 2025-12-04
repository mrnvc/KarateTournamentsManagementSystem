using KTMS.Application.Modules.Cities.Dtos;
using MediatR;

namespace KTMS.Application.Modules.Cities.Queries.GetCities
{
    public class GetCitiesQuery : IRequest<List<CityDto>>
    {
    }
}
