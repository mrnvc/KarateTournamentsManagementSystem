using KTMS.Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KTMS.Application.Modules.Users.Commands.DeleteUser
{
    public class DeleteUserHandler :IRequestHandler<DeleteUserCommand, int>
    {
        private readonly IAppDbContext _dbContext;

        public DeleteUserHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(DeleteUserCommand request ,CancellationToken cancellationToken)
        {
            var user = await _dbContext.Users
                                       .FirstOrDefaultAsync(u => u.Id == request.Id, cancellationToken);
        
            if (user == null)
            {
                throw new Exception("User not found");
            }

            _dbContext.Users.Remove(user);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return 1;
        }
    }
}
