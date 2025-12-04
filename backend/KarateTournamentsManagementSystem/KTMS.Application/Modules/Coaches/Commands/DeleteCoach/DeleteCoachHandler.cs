using KTMS.Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KTMS.Application.Modules.Coaches.Commands.DeleteCoach
{
    public class DeleteCoachHandler : IRequestHandler<DeleteCoachCommand, int>
    {
        private readonly IAppDbContext _dbContext;

        public DeleteCoachHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(DeleteCoachCommand request, CancellationToken cancellationToken)
        {
            var coach = await _dbContext.Coaches.FirstOrDefaultAsync(c => c.Id == request.Id);

            if (coach == null)
            {
                return default;
            }

            _dbContext.Coaches.Remove(coach);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return coach.Id;
        }
    }
}
