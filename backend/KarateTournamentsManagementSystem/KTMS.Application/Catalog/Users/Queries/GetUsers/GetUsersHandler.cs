using KTMS.Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KTMS.Application.Catalog.Users.Queries.GetUsers
{
    public class GetUsersHandler :IRequestHandler<GetUserQuery, List<UserDto>>
    {
        private readonly IAppDbContext _dbContext;

        public GetUsersHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<UserDto>> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Users
                       .Include(u => u.Role)
                       .Include(u => u.City)
                       .Select(u => new UserDto
                       {
                           Id = u.Id,
                           Name = u.Name,
                           Surname = u.Surname,
                           Username = u.Username,
                           PhoneNumber = u.PhoneNumber,
                           Email = u.Email,
                           DateOfBirth = u.DateOfBirth,
                           RegistrationDate = u.RegistrationDate ?? default,
                           Status = u.Status ?? false,
                           Role = u.Role != null ? u.Role.Title : null,
                           City = u.City != null ? u.City.Name : null,
                           Gender = u.Gender != null ? u.Gender.Name : null
                       })
                       .ToListAsync(cancellationToken);
        }
    }
}
