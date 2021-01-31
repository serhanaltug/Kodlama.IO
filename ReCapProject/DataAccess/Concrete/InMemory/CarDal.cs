using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class CarDal : ICarDal
    {
        List<Car> _cars;

        public CarDal()
        {
            _cars = new List<Car> {
                new Car{ Id = 1, ColorId = 1, BrandId = 1, ModelYear = 2018, DailyPrice = 200000, Description = "Sahibinden az kullanılmış kazasız araç." },
                new Car{ Id = 2, ColorId = 1, BrandId = 2, ModelYear = 2020, DailyPrice = 245000, Description = "Henüz 10 bin km.'de acil satılık." },
                new Car{ Id = 3, ColorId = 2, BrandId = 2, ModelYear = 2012, DailyPrice = 120000, Description = "Ön çamurluk değişti." },
                new Car{ Id = 4, ColorId = 3, BrandId = 2, ModelYear = 2010, DailyPrice = 110000, Description = "Kazasız, ikinci sahibiyim." },
                new Car{ Id = 5, ColorId = 4, BrandId = 3, ModelYear = 2018, DailyPrice = 220000, Description = "Bir üst modele geçeceğim için satıyorum." },
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = GetById(car);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(Car car)
        {
            Car entity = _cars.SingleOrDefault(c => c.Id == car.Id);

            return entity;
        }

        public void Update(Car car)
        {
            Car carToUpdate = GetById(car);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
