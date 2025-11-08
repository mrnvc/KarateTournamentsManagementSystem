using KTMS.Application.Catalog.Users.DTOs;
using MediatR;

namespace KTMS.Application.Catalog.Users.Queries.GetUsers
{
    public class GetUserQuery : IRequest<List<UserDto>>
    {
    }
}
