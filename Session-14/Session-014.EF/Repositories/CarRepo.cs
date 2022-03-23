using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session_014.EF.Context;
using Session_14.Model;

namespace Session_014.EF.Repositories
{
    public class CarRepo : IEntityRepo<Car>
    {
        public async Task Create(Car entity)
        {
            using var context = new CarCenterContext();
            context.Cars.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            using var context = new CarCenterContext();
            var foundCar = context.Cars.SingleOrDefault(car => car.ID == id);
            if (foundCar is null)
                return;
            context.Cars.Remove(foundCar);
            await context.SaveChangesAsync();
        }

        public List<Car> GetAll()
        {
            using var context = new CarCenterContext();
            return context.Cars.ToList();
        }

        public Car? GetById(Guid id)
        {
            using var context = new CarCenterContext();
            return context.Cars.Where(car => car.ID == id).SingleOrDefault();
        }

        public async Task Update(Guid id, Car entity)
        {
            using var context = new CarCenterContext();
            var foundCar = context.Cars.SingleOrDefault(car => car.ID == id);
            if (foundCar is null)
                return;
            foundCar.Model = entity.Model;
            foundCar.Brand = entity.Brand;
            foundCar.RegistrationNumber = entity.RegistrationNumber;
            await context.SaveChangesAsync();
        }
    }
}
