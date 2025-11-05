namespace KTMS.Domain.Entities
{
    public class TournamentContestant
    {
        public int Id { get; set; }
        public int TournamentId { get; set; }
        public int ContestantId { get; set; }

        //Navigation Properties
        public Tournament Tournament { get; set; }
        public Contestant Contestant { get; set; }  
    }
}
