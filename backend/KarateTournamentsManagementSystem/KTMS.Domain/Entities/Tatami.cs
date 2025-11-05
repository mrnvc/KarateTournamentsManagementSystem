namespace KTMS.Domain.Entities
{
    public class Tatami
    {
        public int Id { get; set; }
        public int TournamentId { get; set; }
        public int JudgeId { get; set; }
        public required int Number { get; set; }

        //Navigation Properties
        public Tournament Tournament { get; set; }
        public Judge Judge { get; set; }

        //Collections
        public ICollection<Bracket> Brackets { get; set; } = new List<Bracket>(); 
        public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
    }
}
