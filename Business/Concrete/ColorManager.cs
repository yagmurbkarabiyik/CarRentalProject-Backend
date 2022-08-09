using Business.Abstract;
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

        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int id)
        {
            return _colorDal.Get(p => p.ColorId == id);
        }

        public void Update(Color color)
        {
            _colorDal.Delete(color);
        }
    }
}
