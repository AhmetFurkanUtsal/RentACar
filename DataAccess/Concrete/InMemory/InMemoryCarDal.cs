using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal :ICarDal
    { 
        
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>();
            _cars.Add(new Car {BrandId=1,CarId= 1234, ColorId=0001, ModelYear=2024,DailyPrice=2000000,Description="BMW" });
            _cars.Add(new Car {BrandId = 2, CarId=1235,ColorId= 0002, ModelYear= 2024, DailyPrice= 3000000, Description="Volvo" });
            _cars.Add(new Car { BrandId = 3, CarId = 1236, ColorId = 0003, ModelYear = 2024, DailyPrice = 4000000, Description = "Tofaş" });
            _cars.Add(new Car { BrandId = 4, CarId = 1237, ColorId = 0004, ModelYear = 2024, DailyPrice = 5000000, Description = "Audi" });
            _cars.Add(new Car { BrandId = 5, CarId = 1238, ColorId = 0005, ModelYear = 2024, DailyPrice = 6000000, Description = "Ford" });
        }

        public void Add(Car car)
        {
           _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
        }

       

        public List<Car> GetAll()
        {

            return _cars;
        }

        public List<Car> GetbyCarId(int CarId)
        {
            return _cars.Where(p => p.CarId == CarId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;  
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;  
        }
    }
}
