using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails()
        {
            using (var context = new ReCapContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands on car.ColorId equals brand.Id
                             join color in context.Colors on car.BrandId equals color.Id
                             select new CarDetailsDto { CarId = car.Id, CarName = car.Name, BrandName = brand.Name, ColorName = color.Name, DailyPrice = car.DailyPrice };

                return result.ToList();

            }
        }
    }
}
