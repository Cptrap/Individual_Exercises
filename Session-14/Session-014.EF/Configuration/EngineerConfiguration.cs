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
    public class EngineerConfiguration : IEntityTypeConfiguration<Engineer>
    {
        public void Configure(EntityTypeBuilder<Engineer> builder)
        {
            builder.ToTable("Engineer");
            builder.HasKey(engineer => engineer.ID);
            builder.Property(engineer => engineer.ID).ValueGeneratedOnAdd();
            builder.Property(engineer => engineer.Name).HasMaxLength(50);
            builder.Property(engineer => engineer.Surname).HasMaxLength(50);
            builder.Property(engineer => engineer.SallaryPerMonth).HasPrecision(10,3);
            
            
        }
    }
}
