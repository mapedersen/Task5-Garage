using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.App.Entitites
{
    public class Car : Vehicle
    {
        public  string FuelType { get; set; }
        public Car(int numberOfWheels, string registrationNumber, string color, string fuelType) : base(numberOfWheels, registrationNumber, color)
        {
            if (string.IsNullOrWhiteSpace(fuelType)) throw new ArgumentException($"Fueltype cannot be null or empty", nameof(fuelType));
            if (fuelType.ToLower() != "diesel" && fuelType.ToLower() != "gasoline") throw new ArgumentException($"Fueltype can only be set to diesel or gasoline", nameof(fuelType));

            FuelType = fuelType;
        }
    }
}
