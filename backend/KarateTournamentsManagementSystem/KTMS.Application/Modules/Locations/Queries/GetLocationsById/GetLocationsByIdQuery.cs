using KTMS.Application.Modules.Locations.Dtos;
using MediatR;

namespace KTMS.Application.Modules.Locations.Queries.GetLocationsById
{
    public class GetLocationsByIdQuery : IRequest<LocationDto>
    {
        public int Id { get; set; }
        public GetLocationsByIdQuery(int id)
        {
            Id = id;
        }
    }
}
