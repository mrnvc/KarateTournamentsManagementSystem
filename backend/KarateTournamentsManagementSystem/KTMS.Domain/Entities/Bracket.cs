namespace KTMS.Domain.Entities
{
    public class Bracket
    {
        public int Id { get; set; }
        public int TournamentId { get; set; }
        public int TatamiId { get; set; }
        public int ContestantOneId { get; set; }
        public int ContestantTwoId { get; set; }
        public string? Round { get; set; }
        public string? Result { get; set; }

        //Navigation Properties
        public Tournament Tournament { get; set; }
        public Tatami Tatami { get; set; }
        public Contestant ContestantOne { get; set; }
        public Contestant ContestantTwo { get; set; }
    }
}
