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
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Car");
            builder.HasKey(car => car.ID);
            builder.Property(car => car.ID).ValueGeneratedOnAdd();
            builder.Property(car => car.Brand).HasConversion(brand => brand.ToString(),brand => (Brands)Enum.Parse(typeof(Brands), brand)).HasMaxLength(15);
            builder.Property(car => car.Model).HasMaxLength(50);
            builder.Property(car => car.RegistrationNumber).HasMaxLength(20);

        }
    }
}
