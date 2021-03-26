using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager:IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }


        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int brandId)
        {
            return _brandDal.GetById(brandId);
        }

        public void Insert(Brand brand)
        {
            if (brand.BrandName.Length < 2)
            {
                Console.WriteLine("Araba ismi minimum 2 karakter olmalıdır");
            }
            else
            {
                _brandDal.Insert(brand);
            }
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }
    }
}
