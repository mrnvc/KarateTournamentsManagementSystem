using KTMS.Application.Modules.Locations.Dtos;
using MediatR;

namespace KTMS.Application.Modules.Locations.Query.GetLocations
{
    public class GetLocationsQuery : IRequest<List<LocationDto>>
    {
    }
}
