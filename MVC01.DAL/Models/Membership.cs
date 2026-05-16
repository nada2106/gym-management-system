using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC01.DAL.Models
{
    public class Membership
    {
        //Junction table for Members-Plan many-to-many relationship
        public int Id { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
        public int PlanId { get; set; }
        public Plan Plan { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
