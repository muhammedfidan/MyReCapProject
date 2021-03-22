using Business.Abstract;
using Business.Concrete;
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
            InMemoryCarDal carDal = new InMemoryCarDal();
            CarManager carManager = new CarManager(carDal);

            BringAll();
            Console.WriteLine(Environment.NewLine+"EKLEME YAPTIKKTAN SONRA");
            carDal.Add(new Car { Id = 5, BrandId = 1, ColorId = 2, DailyPrice = 200, Description = "Modern", ModelYear = "2021" });
            BringAll();
            Console.WriteLine(Environment.NewLine+ "ID ye gore getir" );
            BringAllFromId();
            Console.WriteLine(Environment.NewLine+"Silme YAPTIKKTAN SONRA");
            carDal.Delete(new Car { Id = 1});
            BringAll();
            Console.WriteLine(Environment.NewLine + "Güncelleme YAPTIKKTAN SONRA");
            carDal.Update(new Car { Id = 3, BrandId = 4, ColorId = 9, DailyPrice = 350, Description = "Son Model, Benzinli", ModelYear = "2022" });
            BringAll();

            void BringAll()
            {
                foreach (var car in carManager.GetAll())
                {
                    Console.WriteLine(car.Id + " " + car.DailyPrice + " " + car.Description + " " + car.ModelYear);
                }
            }

            void BringAllFromId()
            {
                foreach (var car in carDal.GetById(3))
                {
                    Console.WriteLine(car.Id + " " + car.DailyPrice + " " + car.Description + " " + car.ModelYear);
                }
            }

            
        }

      
    }

    

}
