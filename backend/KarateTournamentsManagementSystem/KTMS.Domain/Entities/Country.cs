namespace KTMS.Domain.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        //Navigation Properties
        public ICollection<City> Cities { get; set; } = new List<City>();
        public ICollection<Location> Locations { get; set; } = new List<Location>();
        public ICollection<Club> Clubs { get; set; } = new List<Club>();
    }
}
