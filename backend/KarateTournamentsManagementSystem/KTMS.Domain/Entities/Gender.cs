namespace KTMS.Domain.Entities
{
    public class Gender
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        //Collections
        public ICollection<User> Users { get; set; } = new List<User>();
        public ICollection<Category> Categories { get; set; } = new List<Category>();
    }
}
