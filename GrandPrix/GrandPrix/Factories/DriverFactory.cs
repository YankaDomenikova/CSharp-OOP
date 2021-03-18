namespace GrandPrix.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GrandPrix.Models.Drivers;

    public class DriverFactory
    {
        public Driver CreateDriver(List<string> commandArgs)
        {
            Driver driver = null;

            string type = commandArgs[0];
            string name = commandArgs[1];
            int hp = int.Parse(commandArgs[2]);
            double fuelAmount= double.Parse(commandArgs[3]);
            string tyreType = commandArgs[4];
            double tyreHardness = double.Parse(commandArgs[5]);

            switch (type)
            {
                case "Aggressive":
                    driver = new AggressiveDriver()
                    break;
                case "Endurance":
                    driver = new EnduranceDriver()
                    break;
            }
        }
    }
}
