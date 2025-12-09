using KTMS.Application.Abstractions;
using KTMS.Application.Modules.Locations.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KTMS.Application.Modules.Locations.Queries.GetLocationsById
{
    public class GetLocationsByIdHandler : IRequestHandler<GetLocationsByIdQuery, LocationDto>
    {
        private readonly IAppDbContext _dbContext;

        public GetLocationsByIdHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<LocationDto> Handle(GetLocationsByIdQuery request, CancellationToken cancellationToken)
        {
            var location = await _dbContext.Locations
                                            .Include(l => l.City)
                                            .Include(l => l.Country)
                                            .Where(l => l.Id == request.Id)
                                            .Select(l => new LocationDto
                                            {
                                                Title = l.Title,
                                                Address = l.Address,
                                                City = l.City.Name,
                                                Country = l.Country.Name,
                                                Latitude= l.Latitude,
                                                Longitude= l.Longitude
                                            })
                                            .FirstOrDefaultAsync(cancellationToken);

            if (location == null)
            {
                throw new KeyNotFoundException($"Location with ID {request.Id} not found.");
            }

            return location;
        }
    }
}
