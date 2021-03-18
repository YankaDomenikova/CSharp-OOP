namespace GrandPrix.Models.Drivers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GrandPrix.Models.Cars;

    public class AggressiveDriver : Driver
    {
        private const double A_D_FUEL_CONSUMPTION_PER_KM =  2.7;
        private const double AGGRESSIVE_DRIVER_SPEED_INCREASE= 1.3;

        public AggressiveDriver(string name, Car car, double fuelConsumptionPerKm) 
            : base(name, car, fuelConsumptionPerKm)
        {
            this.FuelConsumptionPerKm = A_D_FUEL_CONSUMPTION_PER_KM;
        }

        public override double Speed => base.Speed * AGGRESSIVE_DRIVER_SPEED_INCREASE;
    }
}
