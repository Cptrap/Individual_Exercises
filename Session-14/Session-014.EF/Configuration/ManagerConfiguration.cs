using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_14.Model;

namespace Session_014.EF.Configuration
{
    public class ManagerConfiguration : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.ToTable("Manager");
            builder.Property(manager => manager.ID);
            builder.Property(manager => manager.ID).ValueGeneratedOnAdd();
            builder.Property(manager => manager.Name).HasMaxLength(50);
            builder.Property(manager => manager.Surname).HasMaxLength(50);
            builder.Property(manager => manager.SallaryPerMonth).HasPrecision(10,3);
        }
    }
}
