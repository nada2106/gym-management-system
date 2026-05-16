using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC01.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC01.DAL.Configurations
{
    internal class MembershipConfiguration : IEntityTypeConfiguration<Membership>
    {
        public void Configure(EntityTypeBuilder<Membership> builder)
        {
            // Configure the many-to-many relationship between Membership and Plan
            builder.HasOne(m => m.Member)
                   .WithMany()
                   .HasForeignKey(m => m.MemberId)
                   .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(m => m.Plan)
                     .WithMany()
                     .HasForeignKey(m => m.PlanId)
                     .OnDelete(DeleteBehavior.Cascade); 

            builder.Property(m => m.StartDate)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
