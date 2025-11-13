using KTMS.Application.Modules.Users.DTOs;
using MediatR;

namespace KTMS.Application.Modules.Users.Queries.GetUsersById
{
    public class GetUsersByIdQuery :IRequest<UserDto>
    {
        public int Id { get; set; }
        public GetUsersByIdQuery(int id)
        {
            Id = id;
        }
    }
}
