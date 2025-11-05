namespace KTMS.Domain.Entities
{
    public class Schedule
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int TournamentId { get; set; }
        public int TatamiId { get; set; }
        public required DateOnly Date { get; set; }
        public required TimeOnly StartTime { get; set; }
        public TimeOnly? EndTime { get; set; }

        //Navigation Properties
        public Category Category { get; set; }
        public Tournament Tournament { get; set; }
        public Tatami Tatami { get; set; }
    }
}
