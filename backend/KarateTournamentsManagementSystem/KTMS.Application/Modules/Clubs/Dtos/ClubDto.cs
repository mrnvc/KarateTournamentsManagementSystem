namespace KTMS.Application.Modules.Clubs.Dtos
{
    public class ClubDto
    {
        public required string Name { get; set; }
        public required string City { get; set; }
        public required string Country { get; set; }
        public required string Address { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public bool? Status { get; set; }
    }
}
