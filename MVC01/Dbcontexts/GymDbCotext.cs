using Microsoft.EntityFrameworkCore;
using MVC01.Models;

namespace MVC01.Dbcontexts
{
    public class GymDbCotext : DbContext
    {
        public DbSet<Plan> Plans { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=GymDb;Trusted_Connection=True;TrustServerCertificate = true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GymDbCotext).Assembly);
        }
    }
}
