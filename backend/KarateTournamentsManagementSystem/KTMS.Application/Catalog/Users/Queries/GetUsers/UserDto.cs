using KTMS.Domain.Entities;

namespace KTMS.Application.Catalog.Users.Queries.GetUsers
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Username { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool Status { get; set; }
        public string? Role { get; set; }
        public string? City { get; set; }
        public string? Gender { get; set; }
    }
}
