using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.App.Entitites.Vehicles
{
    internal class Bus : Vehicle
    {
        public int NumberOfSeats { get; set; }
        public Bus(int numberOfWheels, string registrationNumber, string color, int numberOfSeats) : base(numberOfWheels, registrationNumber, color)
        {
            NumberOfSeats = numberOfSeats;
        }
    }
}
