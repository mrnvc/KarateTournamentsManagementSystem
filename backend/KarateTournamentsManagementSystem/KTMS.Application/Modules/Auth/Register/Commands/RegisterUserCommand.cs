using MediatR;

namespace KTMS.Application.Modules.Auth.Register.Commands
{
    public class RegisterUserCommand : IRequest<int>
    {
        public RegisterDto User { get; set; }
    }
}
