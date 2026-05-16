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
    internal class GymUserConfiguration<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.Name)
                .HasColumnType("varchar")
                .HasMaxLength(50);
            builder.Property(x => x.Email)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            builder.HasIndex(u => u.Email).IsUnique();
            builder.HasIndex(u=>u.PhoneNumber).IsUnique();

            builder.ToTable(tb =>
            {
                tb.HasCheckConstraint("EmailCheck", "Email LIKE '_%@_%._%'");
                tb.HasCheckConstraint("PhoneNumberCheck", "PhoneNumber LIKE '010%' OR PhoneNumber LIKE '011%' OR PhoneNumber LIKE '012%' OR PhoneNumber LIKE '015%'");
            });

            builder.OwnsOne(x => x.Address, a =>
            {
                a.Property(p => p.Street)
                    .HasColumnName("Street")
                    .HasColumnType("varchar")
                    .HasMaxLength(30);
                a.Property(p => p.City)
                    .HasColumnName("City")
                    .HasColumnType("varchar")
                    .HasMaxLength(30);
            });

        }
    }
}
