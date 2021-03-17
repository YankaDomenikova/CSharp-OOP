using GrandPrix.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandPrix.Models.Drivers
{
    public class EnduranceDriver : Driver
    {
        private const double EnduranceDriverFuelConsumption = 1.5;

        public EnduranceDriver(string name, Car car)
            : base(name, car, EnduranceDriverFuelConsumption)
        {
        }
    }
}
