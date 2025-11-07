using KTMS.Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace KTMS.Application.Catalog.Users.Commands.UpdateUser
{
    public class UpdateUserHandler :IRequestHandler<UpdateUserCommand, int>
    {
        private readonly IAppDbContext _dbContext;

        public UpdateUserHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _dbContext.Users.FindAsync(request.Id);

            if (user == null)
            {
                throw new Exception($"User with Id {request.Id} not found.");
            }

            var cityExists = await _dbContext.Cities.AnyAsync(c => c.Id == request.CityId);
            if (!cityExists)
            {
                throw new Exception($"City with Id {request.CityId} not found.");
            }

            var roleExists = await _dbContext.Roles.AnyAsync(x => x.Id == request.RoleId);
            if (!roleExists)
                throw new Exception("Role does not exist.");

            var genderExists = await _dbContext.Genders.AnyAsync(x => x.Id == request.GenderId);
            if (!genderExists)
                throw new Exception("Gender does not exist.");

            user.Name = request.Name;
            user.Surname = request.Surname;
            user.Email = request.Email;
            user.PhoneNumber = request.PhoneNumber;
            user.GenderId = request.GenderId;
            user.RoleId = request.RoleId;
            user.CityId = request.CityId;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return user.Id;
        }
    }
}
