namespace GrandPrix.Models.Cars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GrandPrix.Models.Tyres;

    public class Car
    {
        private const double FUEL_TANK_MAXIMUM_CAPACITY = 160.0;

        private const string OUT_OF_FUEL_ERROR = "Out of fuel";

        private int hp;
        private double fuelAmount;
        private Tyre tyre;

        public Car(int hp, double fuelAmount, Tyre tyre)
        {
            this.Hp = hp;
            this.FuelAmount = fuelAmount;
            this.Tyre = tyre;
        }

        public int Hp 
        {
            get
            {
                return this.hp;
            }
            set
            {
                this.hp = value;
            }
        }
        public double FuelAmount
        {
            get
            {
                return this.fuelAmount;
            }
            set
            {
                if(value < 0)
                {
                    throw new AccessViolationException(OUT_OF_FUEL_ERROR);
                }
                if(value > FUEL_TANK_MAXIMUM_CAPACITY)
                {
                    value = FUEL_TANK_MAXIMUM_CAPACITY;
                }
                else
                {
                    this.fuelAmount = value;
                }
            }
        }
        public Tyre Tyre
        {
            get
            {
                return this.tyre;
            }
            set
            {
                this.tyre = value;
            }
        }
    }
}
