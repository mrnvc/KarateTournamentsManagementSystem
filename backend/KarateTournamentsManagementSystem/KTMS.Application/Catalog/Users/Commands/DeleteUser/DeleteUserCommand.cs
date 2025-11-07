using MediatR;

namespace KTMS.Application.Catalog.Users.Commands.DeleteUser
{
    public class DeleteUserCommand :IRequest<int>
    {
        public int Id { get; set; }
    }
}
