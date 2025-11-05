namespace KTMS.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int DisciplineId { get; set; }
        public int GenderId { get; set; }
        public required string Name { get; set; }
        public required string AgeGroup { get; set; }   
        public required string WeightClass { get; set; }

        //Navigation Properties
        public Discipline Discipline { get; set; }
        public Gender Gender { get; set; }

        //Collections
        public ICollection<Result> Results { get; set; } = new List<Result>();
        public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
        public ICollection<Application> Applications { get; set; } = new List<Application>();
    }
}
