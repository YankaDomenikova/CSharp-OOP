namespace GrandPrix.Models.Tyres
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Tyre
    {
        private const string BLOWN_TYRE_ERROR = "Blown tyre";

        private string name;
        private double hardness;
        private double degradation;

        public Tyre()
        {

        }

        public Tyre(string name, double hardness)
        {
            this.Name = name;
            this.Hardness = hardness;
            this.Degradation = 100;
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
        public double Hardness
        {
            get
            {
                return this.hardness;
            }
            set
            {
                this.hardness = value;
            }
        }
        public virtual double Degradation
        {
            get
            {
                return this.degradation;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException(BLOWN_TYRE_ERROR);
                }
                this.degradation = value;
            }
        }

        public virtual void ReduceDegradation()
        {
            this.Degradation -= this.Hardness;
        }

    }
}
