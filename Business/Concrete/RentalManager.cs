using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<List<Rental>> GetAllById(int id)
        {
            
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(p=>p.Id==id));
        }

        public IResult Insert(Rental rental)
        {
            
            if (rental.ReturnDate==null)
            {

                return new ErrorResult(Messages.CarNotAvailable);

            }
            
            _rentalDal.Insert(rental);
            return new SuccessResult(Messages.Added);
            
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }
    }
}
