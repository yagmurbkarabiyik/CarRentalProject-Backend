using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccesResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccesResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
           var value = _brandDal.GetAll();
            return new SuccesDataResult<List<Brand>>(value, Messages.BrandListed);
        }

        public IDataResult<Brand> GetById(int id)
        {
            var value = _brandDal.Get(p => p.BrandId == id);
            return new SuccesDataResult<Brand>(value, Messages.BrandGetById);
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccesResult(Messages.BrandUpdated);
        }
    }
}

