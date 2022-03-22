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
    internal class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");
            builder.Property(transaction => transaction.ID);
            builder.Property(transaction => transaction.ID).ValueGeneratedOnAdd();
            builder.Property(transaction => transaction.TotalPrice).HasPrecision(10, 3);

        }
    }
}
