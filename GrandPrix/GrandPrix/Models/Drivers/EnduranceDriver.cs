namespace GrandPrix.Models.Drivers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GrandPrix.Models.Cars;


    public class EnduranceDriver : Driver
    {
        private const double E_D_FUEL_CONSUMPTION_PER_KM = 1.5;
        public EnduranceDriver(string name, Car car, double fuelConsumptionPerKm)
            : base(name, car, fuelConsumptionPerKm)
        {
            this.FuelConsumptionPerKm = E_D_FUEL_CONSUMPTION_PER_KM;
        }
    }
}
