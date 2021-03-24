using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
namespace ConsoleUI
{
    class Program
    {

        
        static void Main(string[] args)
        {
            
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            carManager.Add(new Car {ColorId = 1, BrandId = 2, Description="dizel", ModelYear ="2010", DailyPrice = 0 });
            brandManager.Add(new Brand { BrandName = "F" });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " " + car.ModelYear);
            }


            
        }

      
    }

    

}
