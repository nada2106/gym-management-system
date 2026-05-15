using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC01.DAL.Models
{
    public class Booking
    {
        //Junction table for Members-Sessions many-to-many relationship
        public int Id { get; set; }
        public int MemberId { get; set; }
        public DateTime BookingDate { get; set; }
        public bool IsAttended { get; set; }
        public Member Member { get; set; }
        public int SessionId { get; set; }
        public Session Session { get; set; }
    }
}
