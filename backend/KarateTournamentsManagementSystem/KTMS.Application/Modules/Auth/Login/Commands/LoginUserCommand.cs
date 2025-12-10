using MediatR;

namespace KTMS.Application.Modules.Auth.Login.Commands
{
    public class LoginUserCommand : IRequest<string>
    {
        public LoginUserDto User { get; set; }
    }
}
