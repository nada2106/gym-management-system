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
    internal class MemberConfiguration : GymUserConfiguration<Member> , IEntityTypeConfiguration<Member>
    {
        public new void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(x => x.CreatedAt)
                   .HasColumnName("JoinedDate")
                   .HasDefaultValueSql("GETDATE()");
            //plan relation
            builder.HasOne(m => m.Plan)
                   .WithMany(p => p.Members)
                   .HasForeignKey(m => m.PlanId)
                   .OnDelete(DeleteBehavior.Restrict);
            base.Configure(builder);
            //health record relation
            builder.HasOne(m => m.HealthRecord)
                   .WithOne(hr => hr.Member)
                   .HasForeignKey<HealthRecord>(hr => hr.MemberId)
                   .OnDelete(DeleteBehavior.Cascade);
         

            base.Configure(builder);
        }
    }
}
