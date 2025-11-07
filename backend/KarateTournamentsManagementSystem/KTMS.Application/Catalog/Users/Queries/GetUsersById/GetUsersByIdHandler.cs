using KTMS.Application.Abstractions;
using KTMS.Application.Catalog.Users.Queries.GetUsers;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KTMS.Application.Catalog.Users.Queries.GetUsersById
{
    public class GetUsersByIdHandler :IRequestHandler<GetUsersByIdQuery, UserDto>
    {
        private readonly IAppDbContext _dbContext;

        public GetUsersByIdHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UserDto> Handle(GetUsersByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _dbContext.Users
                                        .Include(u => u.Role)
                                        .Include(u => u.City)
                                        .Include(u => u.Gender)
                                        .FirstOrDefaultAsync(u => u.Id == request.Id, cancellationToken);

            if (user == null)
            {
                throw new Exception($"User with Id {request.Id} not found.");
            }

            return new UserDto
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                PhoneNumber = user.PhoneNumber,
                Email = user.Email,
                DateOfBirth = user.DateOfBirth,
                Username = user.Username,
                RegistrationDate = user.RegistrationDate ?? DateTime.MinValue,
                Status = user.Status ?? false,
                Role = user.Role?.Title,
                City = user.City?.Name,
                Gender = user.Gender?.Name
            };
        }
    }
}
