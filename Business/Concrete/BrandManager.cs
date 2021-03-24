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

        public void Add(Brand brand)
        {
            if(brand.BrandName.Length < 2)
            {
                Console.WriteLine("Araba ismi minimum 2 karakter olmalıdır");
            }
            else
            {
                _brandDal.Add(brand);
            }
        }

        public List<Brand> GetCarsByBrandId(int brandId)
        {
            return _brandDal.GetAll(p => p.BrandId == brandId);
        }
    }
}
