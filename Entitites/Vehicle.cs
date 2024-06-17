using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Entitites
{
    public abstract class Vehicle : IVehicle
    {
        public int NumberOfWheels { get; set; }
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }

        public Vehicle(int numberOfWheels, string registrationNUmber, string color)
        {
            if (numberOfWheels <= 0) throw new ArgumentException("Number of wheels must be positive", nameof(numberOfWheels));
            if (string.IsNullOrEmpty(registrationNUmber)) throw new ArgumentException("Registration number cannot be null or empty", nameof(registrationNUmber));
            if (string.IsNullOrWhiteSpace(color)) throw new ArgumentException($"Color cannot be null or whitespace", nameof(color));

            NumberOfWheels = numberOfWheels;
            RegistrationNumber = registrationNUmber.ToUpperInvariant();
            Color = color;
        }

        public string GetDetails()
        {
            return $"Vehicle has {NumberOfWheels} number of wheels\n" +
                   $"Vehicle has registration number: {RegistrationNumber}\n" +
                   $"Vehicle is: {Color}";
        }
    }
}
