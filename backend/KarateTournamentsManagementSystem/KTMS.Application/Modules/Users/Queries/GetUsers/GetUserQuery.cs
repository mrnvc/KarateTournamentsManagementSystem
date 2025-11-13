using KTMS.Application.Modules.Users.DTOs;
using MediatR;

namespace KTMS.Application.Modules.Users.Queries.GetUsers
{
    public class GetUserQuery : IRequest<List<UserDto>>
    {
    }
}
