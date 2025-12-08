using KTMS.Application.Modules.Countries.Dtos;
using MediatR;

namespace KTMS.Application.Modules.Countries.Query.GetCountriesById
{
    public class GetCountriesByIdQuery : IRequest<CountryDto>
    {
        public int Id { get; set; }
        public GetCountriesByIdQuery(int id)
        {
            Id = id;
        }
    }
}
