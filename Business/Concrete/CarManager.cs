using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.Aspect.Performance;
using Core.Aspect.Transaction;
using Core.Aspects.Caching;
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

        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            if (car.ModelName.Length > 2 && car.DailyPrice > 0 )
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.CarAdded);
            }
            return new ErrorResult(Messages.CarNameInvalid);
        }

        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
             return new SuccessResult(Messages.CarDeleted);
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            var value = _carDal.GetAll();
           return new SuccessDataResult<List<Car>>(value, Messages.CarListed);
           
        }

        [CacheAspect]
        [PerformanceAspect(5)]
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
            return new SuccessDataResult<List<Car>>(value, Messages.CarByBrandId);       
        }

        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult( Messages.CarUpdated);
        }
    }
}
