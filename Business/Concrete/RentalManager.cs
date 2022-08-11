using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (rental.ReturnDate == null)
            {
                return new ErrorResult(Messages.ErrorMessage);
            }
            return new SuccesResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccesResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            var value = _rentalDal.GetAll();
            return new SuccesDataResult<List<Rental>>(value, Messages.RentalGetAll);
        }

        public IDataResult<Rental> GetById(int id)
        {
            var value = _rentalDal.Get(p => p.RentalId == id);
            return new SuccesDataResult<Rental>(value, Messages.RentalGetById);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            var value = _rentalDal.GetRentalDetail();
            return new SuccesDataResult<List<RentalDetailDto>>(value, Messages.RentalDetailDto);

        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccesResult(Messages.RentalUpdated);
        }
    }
}
