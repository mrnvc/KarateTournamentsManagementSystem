using KTMS.Application.Catalog.Users.DTOs;
using MediatR;

namespace KTMS.Application.Catalog.Users.Queries.GetUsersById
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
