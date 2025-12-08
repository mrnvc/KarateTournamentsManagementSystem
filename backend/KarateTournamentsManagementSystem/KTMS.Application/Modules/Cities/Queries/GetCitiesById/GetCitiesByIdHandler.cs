using KTMS.Application.Abstractions;
using KTMS.Application.Modules.Cities.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace KTMS.Application.Modules.Cities.Queries.GetCitiesById
{
    public class GetCitiesByIdHandler : IRequestHandler<GetCitiesByIdQuery, CityDto>
    {
        private readonly IAppDbContext _dbContext;

        public GetCitiesByIdHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CityDto> Handle(GetCitiesByIdQuery request, CancellationToken cancellationToken)
        {
            var city = await _dbContext.Cities
                                       .Include(c => c.Country)
                                       .FirstOrDefaultAsync(c => c.Id == request.Id);

            if (city == null)
            {
                throw new Exception("City is not found"); 
            }

            return new CityDto
            {
                CityName = city.Name,
                Country = city.Country.Name
            };
        }
    }
}
