using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarService _carService = new CarManager(new CarDal());

            //var newCar = new Car { Id = 1, BrandId = 1, ColorId = 1, Name = "3 HB AT", ModelYear = 2020, DailyPrice = 200000, Description = "Otomatik vites, cam tavan, deri koltuk" };
            //_carService.Add(newCar);

            List<Car> cars = _carService.GetAll();
            foreach (var car in cars)
            {
                System.Console.WriteLine($"Id: { car.Id }, BrandId: { car.BrandId }, Description: { car.Description }");
            }

        }
    }
}
