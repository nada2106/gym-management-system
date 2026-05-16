namespace MVC01.DAL.Models
{
    public class Plan : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int DurationDays { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        //a plan can be assigned to many members
        public List<Member> Members { get; set; }

    }
}
