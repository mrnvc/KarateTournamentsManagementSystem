using KTMS.Application.Abstractions;
using KTMS.Application.Modules.Locations.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace KTMS.Application.Modules.Locations.Query.GetLocations
{
    public class GetLocationsHandler : IRequestHandler<GetLocationsQuery, List<LocationDto>>
    {
        private readonly IAppDbContext _dbContext;

        public GetLocationsHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<LocationDto>> Handle(GetLocationsQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Locations
                                    .Include(l => l.City)
                                    .Include(l => l.Country)
                                    .Select(l => new LocationDto
                                    {
                                        City = l.City.Name,
                                        Country = l.Country.Name,
                                        Title = l.Title,
                                        Address = l.Address,
                                        Latitude = l.Latitude,
                                        Longitude = l.Longitude
                                    })
                                    .ToListAsync(cancellationToken);
        }
    }
}
