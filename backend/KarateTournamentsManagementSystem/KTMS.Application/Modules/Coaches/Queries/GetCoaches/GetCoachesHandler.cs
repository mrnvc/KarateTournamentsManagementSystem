using KTMS.Application.Abstractions;
using KTMS.Application.Modules.Coaches.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KTMS.Application.Modules.Coaches.Queries.GetCoaches
{
    public class GetCoachesHandler : IRequestHandler<GetCoachesQuery, List<CoachDto>>
    {
        private readonly IAppDbContext _dbContext;

        public GetCoachesHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<CoachDto>> Handle(GetCoachesQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Coaches
                        .Include(c => c.User)
                        .Include(c => c.Belt)
                        .Include(c => c.Club)
                        .Select(c => new CoachDto
                        {
                            Club = c.Club.Name,
                            User = c.User.Name + " " + c.User.Surname,
                            Belt = c.Belt.Name,
                            LicenseNumber = c.LicenseNumber,
                            CertificationLevel = c.CertificationLevel,
                            Verified = c.Verified
                        })
                        .ToListAsync(cancellationToken);
        }
    }
}
