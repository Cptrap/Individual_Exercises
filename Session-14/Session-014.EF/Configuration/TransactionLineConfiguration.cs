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
    internal class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>

    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            builder.ToTable("TransactionLine");
            builder.Property(transactionLine => transactionLine.ID);
            builder.Property(transactionLine => transactionLine.ID).ValueGeneratedOnAdd();
            builder.Property(transactionLine => transactionLine.Hours).HasPrecision(5, 3);
            builder.Property(transactionLine => transactionLine.Price).HasPrecision(10, 3);
            builder.Property(transactionLine => transactionLine.PricePerHour).HasPrecision(2, 1);
        }
    }
}
