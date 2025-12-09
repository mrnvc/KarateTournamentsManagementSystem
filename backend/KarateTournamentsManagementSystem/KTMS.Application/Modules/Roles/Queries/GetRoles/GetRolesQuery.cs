using KTMS.Application.Modules.Roles.Dtos;
using MediatR;

namespace KTMS.Application.Modules.Roles.Queries.GetRoles
{
    public class GetRolesQuery : IRequest<List<RoleDto>>
    {
    }
}
