namespace KTMS.Domain.Entities
{
    public class Discipline
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }

        //Collections
        public ICollection<Category> Categories { get; set; } = new List<Category>();
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public ICollection<Result> Results { get; set; } = new List<Result>();
    }
}
