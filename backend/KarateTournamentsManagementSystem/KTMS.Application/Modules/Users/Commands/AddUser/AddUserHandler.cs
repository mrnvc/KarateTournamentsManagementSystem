using KTMS.Application.Abstractions;
using KTMS.Application.Common.Security;
using KTMS.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTMS.Application.Modules.Users.Commands.AddUser
{
    public class AddUserHandler(IAppDbContext dbContext) :IRequestHandler<AddUserCommand, int>
    {
        public async Task<int> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User
            {
                RoleId = request.RoleId,
                CityId = request.CityId,
                GenderId = request.GenderId,
                Name = request.Name,
                Surname = request.Surname,
                PhoneNumber = request.PhoneNumber,
                Email = request.Email,
                DateOfBirth = request.DateOfBirth,
                Username = request.Username,
                Password = PasswordHasher.Hash(request.Password), 
                RegistrationDate = DateTime.UtcNow,
                Status = true
            };

            dbContext.Users.Add(user);
            await dbContext.SaveChangesAsync(cancellationToken);

            return user.Id;
        }
    }
}
