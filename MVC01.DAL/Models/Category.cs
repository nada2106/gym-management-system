using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC01.DAL.Models
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        //category can be assosiated with many sessions
        public List<Session> Sessions { get; set; }
    }
}
