using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelsHomeWork.Models;
using ModelsHomeWork.Services;

namespace ModelsHomeWork.Controllers
{
    public class DriverController : Controller
    {
        private IDriverService _driverService;
        public DriverController(IDriverService driverService)
        {
            _driverService = driverService;
        }
        public IActionResult Index()
        {
            var drivers = _driverService.GetDrivers();
            if(drivers.Count == 1)
            {
                return View("Details", drivers[0]);
            }
            return View(drivers);
        }

        public IActionResult Details(int id)
        {
            var driver = _driverService.GetDriver(id);
            return View(driver);
        }

        //[HttpGet]
        //public IActionResult Add()
        //{
        //    Driver driver = new Driver();
        //    return View(driver);
        //}
        //[HttpGet]
        //public IActionResult Add(Driver driver)
        //{
        //    var addedDriver = _driverService.CreateDriver(driver);
        //    return View("Details", addedDriver);
        //}
    }
}