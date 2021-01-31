using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
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

            List<Car> cars = _carService.GetAll();
            foreach (var car in cars)
            {
                System.Console.WriteLine($"Id: { car.Id }, BrandId: { car.BrandId }, Description: { car.Description }");
            }

        }
    }
}
