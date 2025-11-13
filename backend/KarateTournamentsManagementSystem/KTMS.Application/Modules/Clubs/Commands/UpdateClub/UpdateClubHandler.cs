using KTMS.Application.Abstractions;
using MediatR;
using KTMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace KTMS.Application.Modules.Clubs.Commands.UpdateClub
{
    public class UpdateClubHandler : IRequestHandler<UpdateClubCommand, int>
    {
        private readonly IAppDbContext _dbContext;

        public UpdateClubHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle (UpdateClubCommand request, CancellationToken cancellationToken)
        {
            var club = await _dbContext.Clubs.FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken);

            if (club == null)
            {
                throw new Exception("Club does not exist.");
            }

            var dto = request.UpdateClubDto;

            club.Name = dto.Name;
            club.Address = dto.Address;
            club.Email = dto.Email;
            club.PhoneNumber = dto.PhoneNumber;
            club.Status = dto.Status;

            await _dbContext.SaveChangesAsync(cancellationToken);
            return club.Id;
        }
    }
}
