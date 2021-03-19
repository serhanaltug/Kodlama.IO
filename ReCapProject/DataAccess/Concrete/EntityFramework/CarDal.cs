using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (var context = new ReCapContext())
            {
                var result = from car in filter is null ? context.Cars : context.Cars.Where(filter)
                             join brand in context.Brands on car.BrandId equals brand.Id
                             join color in context.Colors on car.ColorId equals color.Id
                             select new CarDetailsDto { CarId = car.Id, CarName = car.Name, BrandId=brand.Id, BrandName = brand.Name, ColorId=color.Id, ColorName = color.Name, DailyPrice = car.DailyPrice };

                return result.ToList();

            }
        }
    }
}
