namespace GrandPrix.Models.Tyres
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class UltrasoftTyre : Tyre
    {
        private const string BLOWN_TYRE_ERROR = "Blown tyre";

        private double grip;
        private double degradation;

        public UltrasoftTyre(double hardness, double grip)
            : base()
        {
            this.Grip = grip;
            this.Name = "Ultrasoft";

        }

        public double Grip 
        {
            get
            {
                return this.grip;
            }
            set
            {
                this.grip = value;
            } 
        }

        public override double Degradation
        {
            get
            {
                return this.degradation;
            }
            set
            {
                if (value < 30)
                {
                    throw new ArgumentException(BLOWN_TYRE_ERROR);
                }
                this.degradation = value;
            }
        }
    }
}
