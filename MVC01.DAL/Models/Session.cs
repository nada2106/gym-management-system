namespace MVC01.DAL.Models
{
    public class Session : BaseEntity
    {
        public string Description { get; set; }
        public int Capacity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        //each session is conducted by one trainer
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }
        //each session belongs to one category
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        //each session can be attended by many members
        public List<Member> Members { get; set; }
    }
}