using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session_014.EF.Context;
using Session_14.Model;

namespace Session_014.EF.Repositories
{
    public class TransactionLineRepo : IEntityRepo<TransactionLine>
    {
        public async Task Create(TransactionLine entity)
        {
            using var context = new CarCenterContext();
            context.TransactionLines.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            using var context = new CarCenterContext();
            var foundTransactionLine = context.TransactionLines.SingleOrDefault(transactionLine => transactionLine.ID == id);
            if (foundTransactionLine is null)
                return;
            context.TransactionLines.Remove(foundTransactionLine);
            await context.SaveChangesAsync();
        }

        public List<TransactionLine> GetAll()
        {
            using var context = new CarCenterContext();
            return context.TransactionLines.ToList();
        }

        public TransactionLine? GetById(Guid id)
        {
            using var context = new CarCenterContext();
            return context.TransactionLines.SingleOrDefault(transactionLine => transactionLine.ID == id);
        }

        public async Task Update(Guid id, TransactionLine entity)
        {
            using var context = new CarCenterContext();
            var foundTransactionLine = context.TransactionLines.SingleOrDefault(transactionLine => transactionLine.ID == id);
            if (foundTransactionLine is null)
                return;
            foundTransactionLine.TransactionID = entity.TransactionID;
            foundTransactionLine.ServiceTaskID = entity.ServiceTaskID;
            foundTransactionLine.EngineerID = entity.EngineerID;
            foundTransactionLine.Hours = entity.Hours;
            foundTransactionLine.PricePerHour = entity.PricePerHour;
            foundTransactionLine.Price = entity.Price;
            await context.SaveChangesAsync();
        }
    }
}
