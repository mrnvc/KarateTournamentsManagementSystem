namespace KTMS.Domain.Entities
{
    public class Belt
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int? RankOrder { get; set; }
        public string? Description { get; set; }

        //Navigation Properties
        public ICollection<Coach> Coaches { get; set; }  = new List<Coach>();
        public ICollection<Contestant> Contestants { get; set; }  = new List<Contestant>();
    }
}
