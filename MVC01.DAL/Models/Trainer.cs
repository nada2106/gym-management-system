using MVC01.DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC01.DAL.Models
{
    public class Trainer : GymUser
    {
        public Specialty Specialty { get; set; }
        //hiredate = created at
        //each trainer can attend many sessions
        public List<Session> Sessions { get; set; }
    }
}
