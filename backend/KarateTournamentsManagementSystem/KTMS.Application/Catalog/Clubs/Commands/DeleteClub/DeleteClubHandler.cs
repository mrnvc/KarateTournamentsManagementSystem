using KTMS.Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KTMS.Application.Catalog.Clubs.Commands.DeleteClub
{
    public class DeleteClubHandler : IRequestHandler<DeleteClubCommand, int>
    {
        private readonly IAppDbContext _dbContext;

        public DeleteClubHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }   

        public async Task<int> Handle(DeleteClubCommand request, CancellationToken cancellationToken)
        {
            var club = await _dbContext.Clubs.FirstOrDefaultAsync(c => c.Id == request.Id);
            if (club == null)
            {
                return default;
            }
            _dbContext.Clubs.Remove(club);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return club.Id;
        }
    }
}
