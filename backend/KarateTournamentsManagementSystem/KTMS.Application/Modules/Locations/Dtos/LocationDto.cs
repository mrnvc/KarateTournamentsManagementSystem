namespace KTMS.Application.Modules.Locations.Dtos
{
    public class LocationDto
    {
        public required string City { get; set; }
        public required string Country { get; set; }
        public required string Title { get; set; }
        public required string Address { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}
