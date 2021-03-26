using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();

        IResult Update(Car car);
        IResult Delete(Car car);
        IResult Insert(Car car);

        IDataResult<List<Car>> GetAllById(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();



    }
}
