using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
   public class InMemoryCarDal:ICarDal
   {
       public List<Car> _cars;

       public InMemoryCarDal()
       {
           _cars = new List<Car>()
           {
               new Car()
               {
                   Id = 1,
                   BrandId = 1,
                   ColorId = 1,
                   ModelYear = 2005,
                   DailyPrice = 5000,
                   Description = "Mercedez"

               },
               new Car()
               {
                   Id = 2,
                   BrandId = 2,
                   ColorId = 1,
                   ModelYear = 2005,
                   DailyPrice = 5000,
                   Description = "Renault"

               },
               new Car()
               {
                   Id = 3,
                   BrandId = 3,
                   ColorId = 2,
                   ModelYear = 2005,
                   DailyPrice = 5000,
                   Description = "Ford"

               },
               new Car()
               {
                   Id = 4,
                   BrandId = 4,
                   ColorId = 2,
                   ModelYear = 2005,
                   DailyPrice = 5000,
                   Description = "Audi"

               },
               new Car()
               {
                   Id = 5,
                   BrandId = 5,
                   ColorId = 2,
                   ModelYear = 2005,
                   DailyPrice = 5000,
                   Description = "Toyota"

               }

           };
       }

       public List<Car> GetAll()
       {
           return _cars;
       }

        public List<Car> GetById(int branId)
        {
            return _cars.Where(c => c.Id == branId).ToList();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate;
            carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

        }

        public void Delete(Car car)
        {
            Car carToDelete;

            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }
    }
}
