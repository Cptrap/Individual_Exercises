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
    public class ServiceTaskConfiguration : IEntityTypeConfiguration<ServiceTask>
    {
        public void Configure(EntityTypeBuilder<ServiceTask> builder)
        {
            builder.ToTable("ServiceTask");
            builder.Property(serviceTask => serviceTask.ID);
            builder.Property(serviceTask => serviceTask.ID).ValueGeneratedOnAdd();
            builder.Property(serviceTask => serviceTask.Code).HasMaxLength(50);
            builder.Property(serviceTask => serviceTask.Description).HasMaxLength(100);
            builder.Property(serviceTask => serviceTask.Hours).HasPrecision(10, 3);

        }
    }
}
