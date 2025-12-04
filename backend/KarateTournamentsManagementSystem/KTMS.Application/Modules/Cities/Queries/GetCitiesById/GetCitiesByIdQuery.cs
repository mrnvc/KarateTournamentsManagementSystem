using KTMS.Application.Modules.Cities.Dtos;
using KTMS.Application.Modules.Clubs.Dtos;
using MediatR;

namespace KTMS.Application.Modules.Cities.Queries.GetCitiesById
{
    public class GetCitiesByIdQuery : IRequest<CityDto>
    {
        public int Id { get; set; }
        public GetCitiesByIdQuery(int id)
        {
            Id = id;
        }
    }
}
