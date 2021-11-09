using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelsHomeWork.Models;
using ModelsHomeWork.Services;

namespace ModelsHomeWork.Controllers
{
    public class CarController : Controller
    {
        private ICarService _carService;
        private IDriverService _driverService;
        public CarController(ICarService carService, IDriverService driverService)
        {
            _carService = carService;
            _driverService = driverService;
        }
        public IActionResult Index()
        {
            var cars = _carService.GetCars();
            if(cars.Count ==1)
            {
                return View("Details", cars[0]);
            }
            return View(cars);
        }
        [HttpPost]
        public IActionResult Add(int id)
        {
            var car = new Car();
            ViewBag.DriverId = id;
            return View(car);
        }

        [HttpPost]
        public IActionResult Add(Car car, int driverId)
        {
            car.DriverId = driverId;
            _carService.AddCar(car);
            _driverService.AttachCar(driverId, car);
            return RedirectToAction("Details", "Driver", new { id = driverId });
        }
        public IActionResult Details(int id)
        {
            var car = _carService.GetCar(id);
            return View(car);
        }
    }
}