namespace GrandPrix.Models.Drivers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GrandPrix.Models.Cars;


    public abstract class Driver
    {
        private string name;
        private double totalTime;
        private Car car;
        private double fuelConsumptionPerKm;
        private double speed;

        public Driver(string name, Car car, double fuelConsumptionPerKm)
        {
            this.Name = name;
            this.Car = car;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            } 
        }
        public double TotalTime 
        {
            get
            {
                return this.totalTime;
            }
            set
            {
                this.totalTime = value;
            }
        }
        public Car Car 
        {
            get
            {
                return this.car;
            }
            set
            {
                this.car = value;
            }
        }
        public double FuelConsumptionPerKm 
        {
            get
            {
                return this.fuelConsumptionPerKm;
            }
            set
            {
                this.fuelConsumptionPerKm = value;
            }
        }

        public virtual double Speed => (this.Car.Hp + this.Car.Tyre.Degradation) / this.Car.FuelAmount;
    }
}
