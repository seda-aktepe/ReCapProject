using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car
                {
                    Id=1,
                    BrandId=1,
                    ColorId=1,
                    ModelYear=2019,
                    DailyPrice=150000,
                    Description="Spor"
                },
                new Car
                {
                    Id=2,
                    BrandId=1,
                    ColorId=2,
                    ModelYear=2010,
                    DailyPrice=75000,
                    Description="Sedan"
                },
                new Car
                {
                    Id=3,
                    BrandId=2,
                    ColorId=4,
                    ModelYear=2015,
                    DailyPrice=80000,
                    Description="kangoo"
                },
                new Car
                {
                    Id=4,
                    BrandId=3,
                    ColorId=3,
                    ModelYear=2016,
                    DailyPrice=110000,
                    Description="Hatch Back"
                },
            };
        }
        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id && c.BrandId == car.BrandId && c.ColorId == car.ColorId);
           // _car.Remove(car);
        }
        
        public List<Car> GetById(int brandId, int colorId)
        {
            return _cars.Where(c => c.BrandId == brandId && c.ColorId == colorId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
