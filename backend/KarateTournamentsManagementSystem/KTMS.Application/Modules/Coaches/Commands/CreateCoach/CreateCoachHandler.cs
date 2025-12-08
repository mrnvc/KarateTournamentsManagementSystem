using KTMS.Application.Abstractions;
using KTMS.Application.Modules.Coaches.Dtos;
using KTMS.Domain.Entities;
using MediatR;

namespace KTMS.Application.Modules.Coaches.Commands.CreateCoach
{
    public class CreateCoachHandler : IRequestHandler<CreateCoachCommand, int>
    {
        private readonly IAppDbContext _dbContext;

        public CreateCoachHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(CreateCoachCommand request, CancellationToken cancellationToken)
        {
            var dto = request.CreateCoachDto;

            var coach = new Coach
            {
                ClubId = dto.ClubId,
                UserId = dto.UserId,
                BeltId = dto.BeltId,
                LicenseNumber = dto.LicenseNumber,
                CertificationLevel = dto.CertificationLevel,
                Verified = dto.Verified
            };

            _dbContext.Coaches.Add(coach);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return coach.Id;
        }
    }
}
