using Microsoft.EntityFrameworkCore;
using MVC01.DAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MVC01.DAL.Models
{
    public abstract class GymUser : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Address Address { get; set; }
    }

    [Owned]
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public int BuildingNumber { get; set; }
    }
}
