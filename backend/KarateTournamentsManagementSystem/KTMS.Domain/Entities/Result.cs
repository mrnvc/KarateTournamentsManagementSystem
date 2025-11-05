namespace KTMS.Domain.Entities
{
    public class Result
    {
        public int Id { get; set; }
        public int ContestantId { get; set; }
        public int DisciplineId { get; set; }
        public int CategoryId { get; set; }
        public int TournamentId { get; set; }
        public required string Position { get; set; } //1st, 2nd, 3rd, etc.
        public required int Points { get; set; }
        public required string Award { get; set; } //Gold, Silver, Bronze, etc.

        //Navigation Properties
        public Contestant Contestant { get; set; }
        public Discipline Discipline { get; set; }
        public Category Category { get; set; }
        public Tournament Tournament { get; set; }
    }
}
