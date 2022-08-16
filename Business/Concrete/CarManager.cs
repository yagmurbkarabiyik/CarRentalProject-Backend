using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.ModelName.Length > 2 && car.DailyPrice > 0 )
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.CarAdded);
            }
            return new ErrorResult(Messages.CarNameInvalid);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
             return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            var value = _carDal.GetAll();
           return new SuccessDataResult<List<Car>>(value, Messages.CarListed);
           
        }

        public IDataResult<Car> GetById(int id)
        {
            var value = _carDal.Get(p => p.CarId == id);
            return new SuccessDataResult<Car>(value, Messages.CarGetById) ;
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            var value = _carDal.GetCarDetails();
            return new SuccessDataResult<List<CarDetailDto>>(value, Messages.CarDetail);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            var value = _carDal.GetAll(p => p.BrandId == brandId);
            return new SuccessDataResult<List<Car>>(value, Messages.CarByBrandId);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            var value = _carDal.GetAll(p => p.ColorId == colorId);
            return new SuccessDataResult<List<Car>>(value, Messages.CarByBrandId);        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult( Messages.CarUpdated);
        }
    }
}
