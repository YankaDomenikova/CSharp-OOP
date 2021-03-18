namespace GrandPrix.Models.Tyres
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HardTyre : Tyre
    {
        public HardTyre(double hardness, double grip)
            : base()
        {
            this.Name = "Hard";

        }
    }
}
