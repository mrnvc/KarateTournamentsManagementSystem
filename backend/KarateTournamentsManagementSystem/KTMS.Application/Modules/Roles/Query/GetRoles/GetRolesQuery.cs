using KTMS.Application.Modules.Roles.Dtos;
using MediatR;

namespace KTMS.Application.Modules.Roles.Query.GetRoles
{
    public class GetRolesQuery : IRequest<List<RoleDto>>
    {
    }
}
