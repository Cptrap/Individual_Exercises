using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session_014.EF.Context;
using Session_14.Model;

namespace Session_014.EF.Repositories
{
    public class ManagerRepo : IEntityRepo<Manager>
    {
        public async Task Create(Manager entity)
        {
            using var context = new CarCenterContext();
            context.Managers.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            using var context = new CarCenterContext();
            var foundManager = context.Managers.SingleOrDefault(manager => manager.ID == id);
            if (foundManager is null)
                return;
            context.Managers.Remove(foundManager);
            await context.SaveChangesAsync();
        }

        public List<Manager> GetAll()
        {
            using var context = new CarCenterContext();
            return context.Managers.ToList();
        }

        public Manager? GetById(Guid id)
        {
            using var context = new CarCenterContext();
            return context.Managers.SingleOrDefault(manager => manager.ID == id);
        }

        public async Task Update(Guid id, Manager entity)
        {
            using var context = new CarCenterContext();
            var foundManager = context.Managers.SingleOrDefault(manager => manager.ID == id);
            if (foundManager is null)
                return;
            foundManager.Name = entity.Name;
            foundManager.Surname = entity.Surname;
            foundManager.SallaryPerMonth = entity.SallaryPerMonth;
            await context.SaveChangesAsync();
        }
    }
}
