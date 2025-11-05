namespace KTMS.Domain.Entities
{
    public class Location
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }  
        public required string Title { get; set; }
        public required string Address { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        //Navigation Properties
        public City City { get; set; }
        public Country Country { get; set; }

        //Collections
        public ICollection<Tournament> Tournaments { get; set; } = new List<Tournament>();
    }
}
