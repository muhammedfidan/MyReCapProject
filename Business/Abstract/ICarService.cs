using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();

        void Update(Car car);
        void Delete(Car car);

        void Insert(Car car);
        Car GetById(int carId);
        List<CarDetailDto> GetCarDetails();



    }
}
