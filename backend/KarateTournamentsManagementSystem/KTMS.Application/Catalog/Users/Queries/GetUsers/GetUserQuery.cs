using MediatR;

namespace KTMS.Application.Catalog.Users.Queries.GetUsers
{
    public class GetUserQuery : IRequest<List<UserDto>>
    {
    }
}
