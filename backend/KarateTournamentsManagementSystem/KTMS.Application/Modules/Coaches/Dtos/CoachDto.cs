namespace KTMS.Application.Modules.Coaches.Dtos
{
    public class CoachDto
    {
        public required string Club { get; set; }
        public required string User { get; set; }
        public required string Belt { get; set; }
        public string? LicenseNumber { get; set; }
        public string? CertificationLevel { get; set; }
        public bool? Verified { get; set; }
    }
}
