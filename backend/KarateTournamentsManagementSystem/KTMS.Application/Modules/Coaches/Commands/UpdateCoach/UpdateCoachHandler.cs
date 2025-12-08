using KTMS.Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KTMS.Application.Modules.Coaches.Commands.UpdateCoach
{
    public class UpdateCoachHandler : IRequestHandler<UpdateCoachCommand, int>
    {
        private readonly IAppDbContext _dbContext;

        public UpdateCoachHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(UpdateCoachCommand request, CancellationToken cancellationToken)
        {
            var coach = await _dbContext.Coaches.FirstOrDefaultAsync(c => c.Id == request.Id);

            if (coach == null) { throw new Exception($"Coach with Id {request.Id} not found."); }

            var dto = request.UpdateCoachDto;

            coach.UserId = dto.UserId ?? coach.UserId;
            coach.BeltId = dto.BeltId ?? coach.BeltId;
            coach.ClubId = dto.ClubId ?? coach.ClubId;
            coach.LicenseNumber = dto.LicenseNumber ?? coach.LicenseNumber;
            coach.CertificationLevel = dto.CertificationLevel ?? coach.CertificationLevel;
            coach.Verified = dto.Verified ?? coach.Verified;

            await _dbContext.SaveChangesAsync(cancellationToken);
            return coach.Id;
        }
    }
}
