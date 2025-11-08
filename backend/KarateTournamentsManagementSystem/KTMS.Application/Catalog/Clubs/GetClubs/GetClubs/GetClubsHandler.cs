using KTMS.Application.Abstractions;
using KTMS.Application.Catalog.Clubs.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KTMS.Application.Catalog.Clubs.GetClubs.GetClubs
{
    public class GetClubsHandler : IRequestHandler<GetClubsQuery, List<ClubDto>>
    {
        private readonly IAppDbContext _dbContext;

        public GetClubsHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ClubDto>> Handle(GetClubsQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Clubs
                        .Include(c => c.City)
                        .Include(c => c.Country)
                       .Select(c => new ClubDto
                       {
                           Name = c.Name,
                           City = c.City != null ? c.City.Name : null,
                           Country = c.Country != null ? c.Country.Name : null,
                           Address = c.Address,
                           Email = c.Email,
                           PhoneNumber = c.PhoneNumber,
                           Status = c.Status
                       })
                       .ToListAsync(cancellationToken);
        }
    }
}
