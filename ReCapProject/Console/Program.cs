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
            IBrandService _brandService = new BrandManager(new BrandDal());
            IColorService _colorService = new ColorManager(new ColorDal());
            ICarService _carService = new CarManager(new CarDal());
            IUserService _userService = new UserManager(new UserDal());
            ICustomerService _customerService = new CustomerManager(new CustomerDal());
            IRentalService _rentalService = new RentalManager(new RentalDal());


            //BrandTest();
            //ColorTest();
            //ListAllCars(_carService);
            System.Console.WriteLine("-------------------------------------------------------------------------");

            //_userService.Add(new User { Firstname = "Serhan", Lastname = "Altug", Email = "saltug@yahoo.com", Password = "123456" });
            //_customerService.Add(new Customer { UserId = 1, CompanyName = "SerhanAltug Corp." });


            ListRentals(_rentalService);


            //var rent = _rentalService.Add(new Rental { CarId = 1, CustomerId = 1, RentDate = new DateTime(2020, 01, 10), ReturnDate = null });
            //var rent = _rentalService.Update(new Rental {Id=1, CarId = 1, CustomerId = 1, RentDate = new DateTime(2020, 01, 10), ReturnDate = new DateTime(2021, 02, 12) });

            //System.Console.WriteLine(rent.Message);
            


        }

        private static void BrandTest(IBrandService service)
        {
            service.Add(new Brand { Id = 2, Name = "Mercedes" });
            service.Add(new Brand { Id = 3, Name = "BMW" });
            service.Update(new Brand { Id = 3, Name = "BMW 2" });

            foreach (var brand in service.GetAll().Data)
            {
                System.Console.WriteLine($"Id: { brand.Id }, Name: { brand.Name }");
            }
        }

        private static void ColorTest(IColorService service)
        {
            service.Add(new Color { Id = 2, Name = "Beyaz" });

            foreach (var color in service.GetAll().Data)
            {
                System.Console.WriteLine($"Id: { color.Id }, Name: { color.Name }");
            }
        }

        private static void ListAllCars(ICarService service) 
        {
            //var newCar = new Car { BrandId = 2, ColorId = 2, Name = "3.20", ModelYear = 2020, DailyPrice = 200000, Description = "Otomatik vites, cam tavan, deri koltuk" };
            //service.Add(newCar);

            foreach (var car in service.GetCarDetails().Data)
            {
                System.Console.WriteLine($"Id: { car.CarId }, CarName: { car.CarName }, Brand: { car.BrandName }, Color: {car.ColorName}, DailyPrice: {car.DailyPrice}");
            }
        }

        private static void ListRentals(IRentalService service)
        {
            var result = service.GetRentalDetails();
            if (result.Success)
            {
                foreach (var car in service.GetRentalDetails().Data)
                {
                    System.Console.WriteLine($"CarName: {car.CarName}, {car.BrandName}, Customer: {car.CustomerName}, RentDate: {car.RentDate}, ReturnDate: {car.ReturnDate}");
                }
            }
            else
            {
                System.Console.WriteLine(result.Message);
            }

        }

    }
}
