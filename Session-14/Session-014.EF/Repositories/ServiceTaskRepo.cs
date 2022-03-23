using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session_014.EF.Context;
using Session_14.Model;

namespace Session_014.EF.Repositories
{
    public class ServiceTaskRepo : IEntityRepo<ServiceTask>
    {
        public async Task Create(ServiceTask entity)
        {
            using var context = new CarCenterContext();
            context.ServiceTasks.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            using var context = new CarCenterContext();
            var foundServiceTask = context.ServiceTasks.SingleOrDefault(serviceTask => serviceTask.ID == id);
            if (foundServiceTask is null)
                return;
            context.ServiceTasks.Remove(foundServiceTask);
            await context.SaveChangesAsync();
        }

        public List<ServiceTask> GetAll()
        {
            using var context = new CarCenterContext();
            return context.ServiceTasks.ToList();
        }

        public ServiceTask? GetById(Guid id)
        {
            using var context = new CarCenterContext();
            return context.ServiceTasks.SingleOrDefault(serviceTask => serviceTask.ID == id);
        }

        public async Task Update(Guid id, ServiceTask entity)
        {
            using var context = new CarCenterContext();
            var foundServiceTask = context.ServiceTasks.SingleOrDefault(serviceTask => serviceTask.ID == id);
            if (foundServiceTask is null)
                return;
            foundServiceTask.Code = entity.Code;
            foundServiceTask.Description = entity.Description;
            foundServiceTask.Hours = entity.Hours;
            await context.SaveChangesAsync();
        }
    }
}
