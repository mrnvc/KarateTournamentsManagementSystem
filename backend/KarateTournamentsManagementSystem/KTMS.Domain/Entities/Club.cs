namespace KTMS.Domain.Entities
{
    public class Club
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public required string Name { get; set; }
        public required string Address { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }    
        public bool? Status { get; set; }

        //Navigation Properties
        public City City { get; set; }
        public Country Country { get; set; }

        //Collections 
        public ICollection<Contestant> Contestants { get; set; } = new List<Contestant>();
        public ICollection<Coach> Coaches { get; set; } = new List<Coach>();
    }
}
