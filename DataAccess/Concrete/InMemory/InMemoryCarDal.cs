using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId= 1 , BrandId= 1,ColorId= 4, DailyPrice=100,ModelYear=2001,Description= "Birinci Araba"},
                new Car {CarId= 2 , BrandId= 2,ColorId= 3, DailyPrice=200,ModelYear=2002,Description= "İkinci Araba"},
                new Car {CarId= 3 , BrandId= 1,ColorId= 2, DailyPrice=300,ModelYear=2003,Description= "Üçüncü Araba"},
                new Car {CarId= 4 , BrandId= 2,ColorId= 1, DailyPrice=400,ModelYear=2004,Description= "Dördüncü Araba"},
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            Car carToGet = _cars.SingleOrDefault(c => c.CarId == id);
            return carToGet;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description; 
            carToUpdate.DailyPrice = car.DailyPrice;
        }

   
    }
}
