using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> Get(int id);
        IDataResult<List<CarDetailsDto>> GetCar(int id);
        IDataResult<List<CarDetailsDto>> GetCarsByColorId(int id);
        IDataResult<List<CarDetailsDto>> GetCarsByBrandId(int id);
        IDataResult<List<CarDetailsDto>> GetCarDetails(int? brandId, int? colorId);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
