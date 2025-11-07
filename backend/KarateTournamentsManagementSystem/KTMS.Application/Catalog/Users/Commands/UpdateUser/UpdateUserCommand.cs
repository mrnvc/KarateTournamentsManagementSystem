using MediatR;

namespace KTMS.Application.Catalog.Users.Commands.UpdateUser
{
    public class UpdateUserCommand :IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public int CityId { get; set; }
        public int GenderId { get; set; }
    }
}
