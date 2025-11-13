using MediatR;

namespace KTMS.Application.Modules.Users.Commands.DeleteUser
{
    public class DeleteUserCommand :IRequest<int>
    {
        public int Id { get; set; }
    }
}
