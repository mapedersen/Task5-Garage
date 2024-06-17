using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.App.Entitites.Vehicles
{
    internal class Airplane : Vehicle
    {
        public int NumberOfEngines { get; set; }
        public Airplane(int numberOfWheels, string registrationNumber, string color, int numberOfEngines) : base(numberOfWheels, registrationNumber, color)
        {
            NumberOfEngines = numberOfEngines;
        }
    }
}
