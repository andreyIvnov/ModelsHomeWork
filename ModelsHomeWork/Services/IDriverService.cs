using ModelsHomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsHomeWork.Services
{
    public interface IDriverService
    {
        IList<Driver> GetDrivers();
        Driver GetDriver(int id);
        void AttachCar(int id, Car car);
    }

    public class DriverService : IDriverService
    {

        private List<Driver> _drivers = new List<Driver>()
        {
            new Driver
            {
                Id = 1,
                Name = "Antonio",
                Birthday = new DateTime(1990,5,20),
                Cars = new List<Car>
                {
                    new Car {TypeOfCar="Mustang",Color="Red", DriverId=0, LicensePlate = 123},
                    new Car {TypeOfCar="Supra",Color="white", DriverId=0, LicensePlate = 456},
                    new Car {TypeOfCar="Mustang",Color="Red", DriverId=0, LicensePlate = 789}
                }
            },
            new Driver
            {
                Id = 2,
                Name = "Pablo",
                Birthday = new DateTime(1993,3,25),
                Cars = new List<Car>
                {
                    new Car {TypeOfCar="Mustang",Color="Red", DriverId=1, LicensePlate = 963},
                    new Car {TypeOfCar="Supra",Color="Blue", DriverId=1, LicensePlate = 369},
                }
            },
            new Driver
            {
                Id = 3,
                Name = "Rick",
                Birthday = new DateTime(2010,7,12),
                Cars = new List<Car>
                {
                    new Car {TypeOfCar="Space Ship",Color="Silver", DriverId=3, LicensePlate = 852},
                }
            }
        };

        public IList<Driver> GetDrivers()
        {
            return _drivers;
        }

        public Driver GetDriver(int id)
        {
            return _drivers.Find(driver => driver.Id == id);
        }
        public void AttachCar(int id, Car car)
        {
            _drivers.First(driver => driver.Id == id).Cars.Add(car);
        }

        //public Driver CreateDriver(Driver newDriver)
        //{
        //    int newId = _drivers.Max(driver => driver.Id) + 1;
        //    newDriver.Id = newId;
        //    _drivers.Add(newDriver);
        //    return newDriver;
        //}
    }

}
