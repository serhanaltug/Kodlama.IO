using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        ICarService _carService;

        public CarImageManager(ICarImageDal carImageDal, ICarService carService)
        {
            _carImageDal = carImageDal;
            _carService = carService;
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(CarImage carImage)
        {
            if (CheckIfImageCountOfCarCorrect(carImage.CarId).Success)
            {
                if (CheckIfCarExists(carImage.CarId).Success)
                {
                    _carImageDal.Add(carImage);
                    return new SuccessResult(Messages.Added);            
                }
            }
            return new ErrorResult(Messages.ImageCountError);
        }

        public IResult Update(CarImage carImage)
        {
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<CarImage>> GetAll(int carId)
        {
            var result = _carImageDal.GetAll(x => x.CarId == carId);
            if (result.Count == 0) result.Add(new CarImage { CarId = carId, ImagePath = "DefaultCarImage.png"  });
            return new SuccessDataResult<List<CarImage>>(result);
        }

        private IResult CheckIfImageCountOfCarCorrect(int carId)
        {
            var result = _carImageDal.GetAll(x => x.CarId == carId).Count;
            if (result > 5)
                return new ErrorResult(Messages.ImageCountError);
            return new SuccessResult();
        }

        private IResult CheckIfCarExists(int carId)
        {
            return _carService.Get(carId);
        }
    }
}
