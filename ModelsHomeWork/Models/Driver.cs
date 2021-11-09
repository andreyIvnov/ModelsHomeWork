using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsHomeWork.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public DateTime Birthday { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
