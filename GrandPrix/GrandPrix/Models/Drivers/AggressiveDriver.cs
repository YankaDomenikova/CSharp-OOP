using GrandPrix.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandPrix.Models.Drivers
{
    public class AggressiveDriver : Driver
    {
        private const double AggressiveDriveFuelConsumption = 2.7;
        private const double AggressiveDriverSpeed = 1.3;

        public AggressiveDriver(string name, Car car)
            : base(name, car, AggressiveDriveFuelConsumption)
        {
        }

        public override double Speed => base.Speed * AggressiveDriverSpeed;
    }
}
