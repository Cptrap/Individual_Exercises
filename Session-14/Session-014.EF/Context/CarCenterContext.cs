using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Session_014.EF.Configuration;
using Session_14.Model;

namespace Session_014.EF.Context
{
    public class CarCenterContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Engineer> Engineers { get; set; }
        public DbSet<ServiceTask> ServiceTasks { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionLine> TransactionLines { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CarConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new EngineerConfiguration());
            modelBuilder.ApplyConfiguration(new ManagerConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceTaskConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionLineConfiguration());

            modelBuilder.Entity<Engineer>().HasOne(engineer => engineer.Manager).WithMany(manager => manager.Engineers).HasForeignKey(engineer => engineer.ManagerID);

            modelBuilder.Entity<Transaction>().HasOne(transaction => transaction.Car).WithMany(car => car.Transactions).HasForeignKey(transaction => transaction.CarID);
            modelBuilder.Entity<Transaction>().HasOne(transaction => transaction.Customer).WithMany(customer => customer.Transactions).HasForeignKey(transaction => transaction.CustomerID);
            modelBuilder.Entity<Transaction>().HasOne(transaction => transaction.Manager).WithMany(manager => manager.Transactions).HasForeignKey(transaction => transaction.ManagerID);

            modelBuilder.Entity<TransactionLine>().HasOne(transactionLine => transactionLine.ServiceTask).WithMany(serviceTask => serviceTask.TransactionLines).HasForeignKey(transactionLine => transactionLine.ServiceTaskID);
            modelBuilder.Entity<TransactionLine>().HasOne(transactionLine => transactionLine.Transaction).WithMany(transaction => transaction.TransactionLines).HasForeignKey(transactionLine => transactionLine.TransactionID);
            modelBuilder.Entity<TransactionLine>().HasOne(transactionLine => transactionLine.Engineer).WithMany(engineer => engineer.TransactionLines).HasForeignKey(transactionLine => transactionLine.EngineerID);
            modelBuilder.Entity<TransactionLine>().Property(transactionLine => transactionLine.PricePerHour).HasDefaultValue(44.5);
        }   
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);
            var connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbCarCenter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(connString);
        }

    }
}
