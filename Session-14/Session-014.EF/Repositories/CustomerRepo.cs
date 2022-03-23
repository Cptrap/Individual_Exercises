using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session_014.EF.Context;
using Session_14.Model;

namespace Session_014.EF.Repositories
{
    public class CustomerRepo : IEntityRepo<Customer>
    {
        public async Task Create(Customer entity)
        {
            using var context = new CarCenterContext();
            context.Customers.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            using var context = new CarCenterContext();
            var foundCustomer = context.Customers.SingleOrDefault(customer => customer.ID == id);
            if (foundCustomer is null)
                return;
            context.Customers.Remove(foundCustomer);
            await context.SaveChangesAsync();
        }

        public List<Customer> GetAll()
        {
            using var context = new CarCenterContext();
            return context.Customers.ToList();
        }

        public Customer? GetById(Guid id)
        {
            using var context = new CarCenterContext();
            return context.Customers.Where(customer => customer.ID == id).SingleOrDefault();
        }

        public async Task Update(Guid id, Customer entity)
        {
            using var context = new CarCenterContext();
            var foundCustomer = context.Customers.SingleOrDefault(customer => customer.ID == id);
            if (foundCustomer is null)
                return;
            foundCustomer.TIN = entity.TIN;
            foundCustomer.Phone = entity.Phone;
            foundCustomer.Surname = entity.Surname;
            foundCustomer.Name = entity.Name;
            await context.SaveChangesAsync();
        }
    }
}
