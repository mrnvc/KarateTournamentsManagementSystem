using KTMS.Domain.Entities;

namespace KTMS.Application.Modules.Judges.Dtos
{
    public class JudgeFilterDto
    {
        //public int Id { get; set; }
        public string? License { get; set; }
        public string? Rank { get; set; }
    }
}
