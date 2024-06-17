using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.App.Entitites.Vehicles
{
    internal class Motorcycle : Vehicle
    {
        public int CylinderVolume { get; set; }
        public Motorcycle(int numberOfWheels, string registrationNumber, string color, int cylinderVolume) : base(numberOfWheels, registrationNumber, color)
        {
            CylinderVolume = cylinderVolume;
        }
    }
}
