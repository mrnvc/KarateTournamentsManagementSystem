namespace KTMS.Application.Modules.Coaches.Dtos
{
    public class UpdateCoachDto
    {
        public int? ClubId { get; set; }
        public int? UserId { get; set; }
        public int? BeltId { get; set; }
        public string? LicenseNumber { get; set; }
        public string? CertificationLevel { get; set; }
        public bool? Verified { get; set; }
    }
}
