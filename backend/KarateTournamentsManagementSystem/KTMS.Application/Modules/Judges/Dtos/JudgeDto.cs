namespace KTMS.Application.Modules.Judges.Dtos
{
    public class JudgeDto
    {
        public required int Id { get; set; }
        public required int UserId { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Email { get; set; }
        public required string License { get; set; }
        public required string Rank { get; set; }
    }
}
