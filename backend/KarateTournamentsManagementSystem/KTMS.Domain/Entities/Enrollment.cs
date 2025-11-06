namespace KTMS.Domain.Entities
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ContestantId { get; set; }
        public int TournamentId { get; set; }
        public int DisciplineId { get; set; }
        public required DateOnly ApplicationDate { get; set; }
        public required string Status { get; set; } //e.g., Pending, Approved, Rejected
        public required bool Paid { get; set; }   

        //Navigation Properties
        public Category Category { get; set; }
        public Contestant Contestant { get; set; }
        public Tournament Tournament { get; set; }
        public Discipline Discipline { get; set; }

        //Collections
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
