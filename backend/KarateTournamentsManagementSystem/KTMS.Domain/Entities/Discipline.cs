namespace KTMS.Domain.Entities
{
    public class Discipline
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }

        //Collections
        public ICollection<Category> Categories { get; set; } = new List<Category>();
        public ICollection<Application> Applications { get; set; } = new List<Application>();
        public ICollection<Result> Results { get; set; } = new List<Result>();
    }
}
