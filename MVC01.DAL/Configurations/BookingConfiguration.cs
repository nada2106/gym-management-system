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
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            //Junction table for Members-Sessions many-to-many relationship
            builder.HasOne(b => b.Member)
                    .WithMany()
                    .HasForeignKey(b => b.MemberId);
            builder.HasOne(b => b.Session)
                    .WithMany()
                    .HasForeignKey(b => b.SessionId);

            builder.Property(b => b.BookingDate)
                    .HasDefaultValueSql("GETDATE()");
        }
    }
}
