namespace KTMS.Domain.Entities
{
    public class Notification
    {
        public int Id { get; set; }
        public int TournamentId { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
        public required DateTime PublishDate { get; set; }
        public required string Author { get; set; }

        //Navigation Properties
        public Tournament Tournament { get; set; }
    }
}
