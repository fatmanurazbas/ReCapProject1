using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Car> _cars;
        public InMemoryProductDal()
        {
            _cars = new List<Car>
            {
                // CarId, BrandId, ColorId, ModelYear, DailyPrice, Description
                new Car{ CarId=1, BrandId=1, ColorId=1, ModelYear=2020, DailyPrice=1200, Description="BMW" },
                new Car{ CarId=2, BrandId=2, ColorId=1, ModelYear=2021, DailyPrice=1500, Description="Mercedes" },
                new Car{ CarId=3, BrandId=3, ColorId=2, ModelYear=2019, DailyPrice=800, Description="Audi" },
                new Car{ CarId=4, BrandId=4, ColorId=2, ModelYear=2020, DailyPrice=500, Description="Renault" },
                new Car{ CarId=5, BrandId=5, ColorId=4, ModelYear=2022, DailyPrice=800, Description="Volkswagen" }
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

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.CarId == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
        }
    }
}
