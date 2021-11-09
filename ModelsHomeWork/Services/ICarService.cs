using ModelsHomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsHomeWork.Services
{
    public interface ICarService
    {
        IList<Car> GetCars();
        Car GetCar(int id);
        Car AddCar(Car car);
    }

    public class CarService : ICarService
    {
        private List<Car> _cars = new List<Car>()
        {
                    new Car {TypeOfCar="Mustang",Color="Red", DriverId=1, LicensePlate = 123},
                    new Car {TypeOfCar="Supra",Color="white", DriverId=0, LicensePlate = 456}
        };
        public Car GetCar(int id)
        {
            return _cars.Find(car => car.Id == id);
        }

        public IList<Car> GetCars()
        {
            return _cars;
        }
        public Car AddCar(Car car)
        {
            _cars.Add(car);
            return car;
        }

    }
}
