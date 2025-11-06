namespace KTMS.Domain.Entities
{
    public class Tournament
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public required string Title { get; set; }
        public required DateOnly Date { get; set; }
        public required TimeOnly StartTime { get; set; }
        public TimeOnly? EndTime { get; set; }
        public string? Description { get; set; }
        public required string RegistrationFee { get; set; }
        public required string Status { get; set; } 

        //Navigation Properties
        public Location Location { get; set; }

        //Collections
        public ICollection<Organizer> Organizers { get; set; } = new List<Organizer>();
        public ICollection<TournamentJudge> TournamentJudges { get; set; } = new List<TournamentJudge>();
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
        public ICollection<Bracket> Brackets { get; set; } = new List<Bracket>();
        public ICollection<Result> Results { get; set; } = new List<Result>();
        public ICollection<Tatami> Tatamis { get; set; } = new List<Tatami>();
        public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
        public ICollection<TournamentContestant> TournamentContestants { get; set; } = new List<TournamentContestant>();
    }
}
