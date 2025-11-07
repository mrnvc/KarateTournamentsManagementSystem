using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTMS.Application.Catalog.Users.Commands.AddUser
{
    public class AddUserCommand :IRequest<int>
    {
        public int RoleId { get; set; }
        public int CityId { get; set; }
        public int GenderId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
