using System.ComponentModel.DataAnnotations;

namespace MVC01.DAL.Models
{
    public class HealthRecord 
    {

        public double Weight { get; set; }
        public double Height { get; set; }
        public string BloodType { get; set; }
        public string Note { get; set; }
        //last updated = updated at
        //each health record belongs to one member
        [Key]
        public int MemberId { get; set; }//id of the member that this health record belongs to
        public Member Member { get; set; }
    }
}