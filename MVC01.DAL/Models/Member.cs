using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC01.DAL.Models
{
    public class Member : GymUser
    {
        public string? Photo { get; set; }
        //JoinDate = created at
        //each member has one HealthRecord
        public HealthRecord HealthRecord { get; set; }
        //each member subscribes to one plan
        public int PlanId { get; set; }
        public Plan Plan { get; set; }
        //each member can attend many sessions
        public List<Session> Sessions { get; set; }

    }
}
