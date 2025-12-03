namespace KTMS.Application.Modules.Judges.Dtos
{
    public class CreateJudgeDto
    {
        public int UserId { get; set; }
        public required string License { get; set; }
        public string? Rank { get; set; }
    }
}
