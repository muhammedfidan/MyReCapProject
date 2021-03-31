using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new Result(true, Messages.Deleted);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<List<Car>> GetAllById(int carId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.Id == carId));
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Insert(Car car)
        {

           
                _carDal.Insert(car);
            
                
              
          
            return new SuccessResult(Messages.Added);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new Result(true, Messages.Updated);
        }
    }
}
