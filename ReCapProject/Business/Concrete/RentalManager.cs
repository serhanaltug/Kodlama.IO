using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;

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
            if (Check(rental).Success)
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.Added);
            }
            return new ErrorResult(Check(rental).Message);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.Deleted);
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

        public IResult Check(Rental rental)
        {
            if (rental.RentDate < DateTime.Now) return new ErrorResult(Messages.RentDateCannotLessThenToday);
            if (rental.ReturnDate < rental.RentDate) return new ErrorResult(Messages.RentDateError);

            var result = _rentalDal.GetRentalDetails(x => x.CarId == rental.CarId && x.ReturnDate == null);
            if (result.Count > 0)
                return new ErrorResult(Messages.CarCanNotBeRentError);

            //var rentable = true;
            //var rentals = _rentalDal.GetRentalDetails(x => x.CarId == rental.CarId);
            //if (rentals.Count > 0)
            //{
            //    foreach(var car in rentals)
            //    {
            //        if (rental.ReturnDate < car.RentDate || rental.RentDate > car.ReturnDate) rentable = true;
            //    }

            //    if (!rentable)
            //    {
            //        return new ErrorResult(Messages.RentCheckFailed);
            //    }
            //}

            return new SuccessResult(Messages.RentCheckSuccess);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }
    }
}
