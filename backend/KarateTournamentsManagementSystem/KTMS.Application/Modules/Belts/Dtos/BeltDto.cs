namespace KTMS.Application.Modules.Belts.Dtos
{
    public class BeltDto
    {
        public required string Name { get; set; }
        public int? RankOrder { get; set; }
        public string? Description { get; set; }
    }
}
