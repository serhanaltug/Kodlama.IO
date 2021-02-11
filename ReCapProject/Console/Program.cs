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
            //BrandTest();
            //ColorTest();
            CarTest();

        }

        private static void BrandTest()
        {
            IBrandService _brandService = new BrandManager(new BrandDal());
            _brandService.Add(new Brand { Id = 2, Name = "Mercedes" });
            _brandService.Add(new Brand { Id = 3, Name = "BMW" });
            _brandService.Update(new Brand { Id = 3, Name = "BMW 2" });

            foreach (var brand in _brandService.GetAll().Data)
            {
                System.Console.WriteLine($"Id: { brand.Id }, Name: { brand.Name }");
            }
        }

        private static void ColorTest()
        {
            IColorService _colorService = new ColorManager(new ColorDal());
            _colorService.Add(new Color { Id = 2, Name = "Beyaz" });

            foreach (var color in _colorService.GetAll().Data)
            {
                System.Console.WriteLine($"Id: { color.Id }, Name: { color.Name }");
            }
        }

        private static void CarTest() 
        {
            ICarService _carService = new CarManager(new CarDal());
            //var newCar = new Car { Id = 3, BrandId = 2, ColorId = 2, Name = "3.20", ModelYear = 2020, DailyPrice = 200000, Description = "Otomatik vites, cam tavan, deri koltuk" };
            //_carService.Add(newCar);

            foreach (var car in _carService.GetCarDetails().Data)
            {
                System.Console.WriteLine($"Id: { car.CarId }, CarName: { car.CarName }, Brand: { car.BrandName }, Color: {car.ColorName}, DailyPrice: {car.DailyPrice}");
            }
        }
    }
}
