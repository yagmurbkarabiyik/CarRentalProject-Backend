using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal 
    {
        //List<Car> _cars;

        //public InMemoryCarDal()
        //{
        //    _cars = new List<Car>
        //    {
        //        new Car{CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 100, Description = "Son Model", ModelYear = 2022},
        //        new Car{CarId = 2, BrandId = 2, ColorId = 3, DailyPrice = 200, Description = "İkinci El", ModelYear = 2016},
        //        new Car{CarId = 3, BrandId = 2, ColorId = 4, DailyPrice = 150, Description = "Sahibinden", ModelYear = 2016},
        //        new Car{CarId = 4, BrandId = 1, ColorId = 2, DailyPrice = 250, Description = "Son Model", ModelYear = 2022},
        //    };
            
        //}

        //public void Add(Car car)
        //{
        //    _cars.Add(car);
        //}

        //public void Delete(Car car)
        //{            
        //   Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

        //    _cars.Remove(carToDelete);
        //}

        //public List<Car> GetAll()
        //{
        //    return _cars;
        //}
        //public List<Car> GetById(int Id)
        //{
        //    return _cars.Where(c => c.CarId == Id).ToList();
        //}

        //public void Update(Car car)
        //{
        //    Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        //    carToUpdate.CarId = car.CarId;
        //    carToUpdate.BrandId = car.BrandId;
        //    carToUpdate.ColorId = car.ColorId;
        //    carToUpdate.DailyPrice = car.DailyPrice;
        //    carToUpdate.Description = car.Description;

        //}

    }
}
