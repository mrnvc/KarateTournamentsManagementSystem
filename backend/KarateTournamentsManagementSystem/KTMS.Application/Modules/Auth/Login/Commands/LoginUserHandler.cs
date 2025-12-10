using KTMS.Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KTMS.Application.Modules.Auth.Login.Commands
{
    public class LoginUserHandler : IRequestHandler<LoginUserCommand, string>
    {
        private readonly IAppDbContext _dbContext;
        private readonly IJwtService _jwtService;

        public LoginUserHandler(IAppDbContext dbContext, IJwtService jwtService)
        {
            _dbContext = dbContext;
            _jwtService = jwtService;
        }

        public async Task<string> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            //find user by email or password   
            var user = await _dbContext.Users
                                        .FirstOrDefaultAsync(u => u.Email == request.User.Email 
                                        || u.Password == request.User.Password, cancellationToken);
            
            if (user == null)
            {
                throw new UnauthorizedAccessException("Invalid email or password.");
            }

            //password verification
            bool valid = BCrypt.Net.BCrypt.Verify(request.User.Password, user.Password);
            if (!valid)
            {
                throw new Exception("Invalid email or password!");
            }

            //generating a token
            var token = _jwtService.GenerateToken(user);
            return token;
        }
    }
}
