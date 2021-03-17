using GrandPrix.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandPrix.Factories
{
    public class CarFactory
    {
        public static Car CreateCar(List<string> commandArgs, Tyre tyre)
        {
            return new Car(int.Parse(commandArgs[0]), double.Parse(commandArgs[1]), tyre);
        }
    }
}
