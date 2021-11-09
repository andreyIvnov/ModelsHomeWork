using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsHomeWork.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string TypeOfCar { get; set; }
        public string Color { get; set; }
        public int LicensePlate { get; set; }
        public int? DriverId { get; set; }
    }
}
