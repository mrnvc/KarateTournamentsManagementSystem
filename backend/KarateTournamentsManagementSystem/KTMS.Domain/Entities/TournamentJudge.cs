namespace KTMS.Domain.Entities
{
    public class TournamentJudge
    {
        public int Id { get; set; }
        public int JudgeId { get; set; }
        public int TournamentId { get; set; }
        public string? Role { get; set; }

        //Navigation Properties
        public Judge Judge { get; set; }
        public Tournament Tournament { get; set; }
    }
}
