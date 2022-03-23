using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session_014.EF.Context;
using Session_14.Model;

namespace Session_014.EF.Repositories
{
    public class EngineerRepo : IEntityRepo<Engineer>
    {
        public async Task Create(Engineer entity)
        {
            using var context = new CarCenterContext();
            context.Engineers.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            using var context = new CarCenterContext();
            var foundEngineer = context.Engineers.SingleOrDefault(engineer => engineer.ID == id);
            if (foundEngineer is null)
                return;
            context.Engineers.Remove(foundEngineer);
            await context.SaveChangesAsync();
        }

        public List<Engineer> GetAll()
        {
            using var context = new CarCenterContext();
            return context.Engineers.ToList();
        }

        public Engineer? GetById(Guid id)
        {
            using var context = new CarCenterContext();
            return context.Engineers.SingleOrDefault(engineer => engineer.ID == id);
        }

        public async Task Update(Guid id, Engineer entity)
        {
            using var context = new CarCenterContext();
            var foundEngineer = context.Engineers.SingleOrDefault(engineer => engineer.ID == id);
            if (foundEngineer is null)
                return;
            foundEngineer.Name = entity.Name;
            foundEngineer.Surname = entity.Surname;
            foundEngineer.SallaryPerMonth=entity.SallaryPerMonth;
            foundEngineer.ManagerID = entity.ManagerID;
            await context.SaveChangesAsync();
        }
    }
}
