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
    public class ColorManager : ICarColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal carColorDal)
        {
            _colorDal = carColorDal;
        }

        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccesResult(Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccesResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            var value = _colorDal.GetAll();
            return new SuccesDataResult<List<Color>>(value, Messages.ColorGet);
        }

        public IDataResult<Color> GetById(int id)
        {
            var value = _colorDal.Get(p => p.ColorId == id);
            return new SuccesDataResult<Color>(value, Messages.ColorGetById);
        }

        public IResult Update(Color color)
        {
            _colorDal.Delete(color);
            return new SuccesResult(Messages.CarUpdated);
        }
    }
}
