using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session_014.EF.Context;
using Session_14.Model;
namespace Session_014.EF.Repositories
{
    public class TransactionRepo : IEntityRepo<Transaction>
    {
        public async Task Create(Transaction entity)
        {
            using var context = new CarCenterContext();
            context.Transactions.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            using var context = new CarCenterContext();
            var foundTransaction = context.Transactions.SingleOrDefault(transaction => transaction.ID == id);
            if (foundTransaction is null)
                return;
            context.Transactions.Remove(foundTransaction);
            await context.SaveChangesAsync();
        }

        public List<Transaction> GetAll()
        {
            using var context = new CarCenterContext();
            return context.Transactions.ToList();
           
        }

        public Transaction? GetById(Guid id)
        {
            using var context = new CarCenterContext();
            return context.Transactions.SingleOrDefault(transaction => transaction.ID == id);
        }

        public async Task Update(Guid id, Transaction entity)
        {
            using var context = new CarCenterContext();
            var foundTransaction = context.Transactions.SingleOrDefault(transaction => transaction.ID == id);
            if (foundTransaction is null)
                return;
            foundTransaction.Date = DateTime.Now;
            foundTransaction.CustomerID = entity.CustomerID;
            foundTransaction.CarID = entity.CarID;
            foundTransaction.ManagerID = entity.ManagerID;
            foundTransaction.TotalPrice = entity.TotalPrice;
            await context.SaveChangesAsync();
        }
    }
}
