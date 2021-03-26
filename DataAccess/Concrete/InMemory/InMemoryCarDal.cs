using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : IEntityRepository<Car>
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId=1, ColorId = 1, DailyPrice = 87, Description ="Klimali, Dizel", ModelYear="2020"},
                new Car{Id = 2, BrandId=2, ColorId = 2, DailyPrice = 100, Description ="Benzinli", ModelYear="2018"},
                new Car{Id = 3, BrandId=1, ColorId = 3, DailyPrice = 110, Description ="4x4", ModelYear="2015"},
                new Car{Id = 4, BrandId=2, ColorId = 1, DailyPrice = 200, Description ="Modern", ModelYear="2021"},
            };
        }

        public void Insert(Car car)
        {
            _cars.Add(car);
        }

       

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int getById)
        {
            return _cars.Where(p => p.Id == getById).ToList();

        }

        public Car GetById(object EntityId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
        }

       
    }
}
