namespace KTMS.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int CityId { get; set; }
        public int GenderId { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Email { get; set; }
        public required DateTime DateOfBirth { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public bool? Status { get; set; }

        //Navigation Properties 
        public Role Role { get; set; }
        public City City { get; set; }
        public Gender Gender { get; set; }

        //Collections
        public ICollection<Contestant> Contestants { get; set; } = new List<Contestant>();
        public ICollection<Coach> Coaches { get; set; } = new List<Coach>();
        public ICollection<Judge> Judges { get; set; } = new List<Judge>();
        public ICollection<Organizer> Organizers { get; set; } = new List<Organizer>();
    }
}
