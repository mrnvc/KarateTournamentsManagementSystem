using KTMS.Application.Abstractions;
using KTMS.Application.Modules.Roles.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KTMS.Application.Modules.Roles.Query.GetRoles
{
    public class GetRolesHandler : IRequestHandler<GetRolesQuery, List<RoleDto>>
    {
        private readonly IAppDbContext _dbContext;

        public GetRolesHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<RoleDto>> Handle(GetRolesQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Roles
                                  .Select(role => new RoleDto
                                  {
                                      Title = role.Title,
                                      Description = role.Description,
                                      Status = role.Status
                                  })
                                  .ToListAsync(cancellationToken);
        }
    }
}
