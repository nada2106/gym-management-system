using Microsoft.EntityFrameworkCore;
using MVC01.DAL.Models;

namespace MVC01.Dbcontexts
{
    public class GymDbCotext : DbContext
    {
        public DbSet<Plan> Plans { get; set; } = null!;
        public DbSet<Trainer> Trainers { get; set; } = null!;
        public DbSet<Member> Members { get; set; } = null!;
        public DbSet<Session> Sessions { get; set; } = null!;
        public DbSet<Booking> Bookings { get; set; } = null!;
        public DbSet<Membership> Memberships { get; set; } = null!;

        public GymDbCotext(DbContextOptions<GymDbCotext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GymDbCotext).Assembly);
        }
    }
}
