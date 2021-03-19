using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [SecuredOperation("admin,editor")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Messages.Added);
        }

        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.Updated);
        }

        [CacheRemoveAspect("ICarService.Get")]
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.Deleted);
        }

        [PerformanceAspect(5)]
        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<List<CarDetailsDto>> GetCarDetails(int? brandId, int? colorId)
        {
            var cars = _carDal.GetCarDetails();
            if (brandId > 0 && (colorId == null || colorId == 0)) cars = _carDal.GetCarDetails(x => x.BrandId == brandId);
            if (colorId > 0 && (brandId == null || brandId == 0)) cars = _carDal.GetCarDetails(x => x.ColorId == colorId);
            if (brandId > 0 && colorId > 0) cars = _carDal.GetCarDetails(x => x.BrandId == brandId && x.ColorId == colorId);
            return new SuccessDataResult<List<CarDetailsDto>>(cars);
        }

        public IDataResult<List<CarDetailsDto>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<CarDetailsDto>>(_carDal.GetCarDetails(x => x.BrandId == id));
        }

        public IDataResult<List<CarDetailsDto>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<CarDetailsDto>>(_carDal.GetCarDetails(x => x.ColorId == id));
        }

        public IDataResult<Car> Get(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(x => x.Id == id));
        }

        public IDataResult<List<CarDetailsDto>> GetCar(int id)
        {
            return new SuccessDataResult<List<CarDetailsDto>>(_carDal.GetCarDetails(x => x.Id == id));
        }
    }
}
