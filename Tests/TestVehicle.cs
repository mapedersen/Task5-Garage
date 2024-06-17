using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.Entitites;

namespace Task5.Test
{
    internal class TestVehicle : Vehicle
    {
        public TestVehicle(int numberOfWheels, string registrationNUmber, string color) : base(numberOfWheels, registrationNUmber, color)
        {
        }
    }
}
