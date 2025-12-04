using KTMS.Application.Abstractions;
using KTMS.Application.Modules.Coaches.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks.Sources;

namespace KTMS.Application.Modules.Coaches.Queries.GetCoachesById
{
    public class GetCoachesByIdHandler : IRequestHandler<GetCoachesByIdQuery, CoachDto>
    {
        private readonly IAppDbContext _dbContext;

        public GetCoachesByIdHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CoachDto> Handle(GetCoachesByIdQuery request, CancellationToken cancellationToken)
        {
            var coach = await _dbContext.Coaches
                                        .Include(c => c.Club)
                                        .Include(c => c.User)
                                        .Include(c => c.Belt)
                                        .FirstOrDefaultAsync(c => c.Id == request.Id);

            if (coach == null) { 
                throw new Exception("Coach not found");
            }

            return new CoachDto
            {
                Club = coach.Club.Name,
                User = $"{coach.User.Name} {coach.User.Surname}",
                Belt = coach.Belt.Name,
                LicenseNumber = coach.LicenseNumber,
                CertificationLevel = coach.CertificationLevel,
                Verified = coach.Verified
            };
        }
    }
}
