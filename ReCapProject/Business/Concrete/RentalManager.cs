using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            var result = _rentalDal.GetRentalDetails(x=> x.CustomerId == rental.CustomerId && x.CarId == rental.CarId && x.ReturnDate == null);
            if (result.Count > 0)
                return new ErrorResult("Araba şu anda kirada olduğu için tekrar kiralanamaz.");
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<Rental> Get(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(x => x.Id == id));
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<List<RentalDetailsDto>> GetRentalDetails()
        {
            var result = _rentalDal.GetRentalDetails();
            if (result.Count > 0)
            {
                return new SuccessDataResult<List<RentalDetailsDto>>(result);
            }
            else
                return new ErrorDataResult<List<RentalDetailsDto>>("Veritabanında hiç kayıt bulunmamaktadır.");
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }
    }
}
