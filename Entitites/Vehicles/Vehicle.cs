using Task5.App.Tools;

namespace Task5.App.Entitites.Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        public int NumberOfWheels { get; set; }
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }

        public Vehicle(int numberOfWheels, string registrationNumber, string color)
        {
            var validator = new VehicleValidator();
            validator.ValidateVehicle(numberOfWheels, registrationNumber, color);

            NumberOfWheels = numberOfWheels;
            RegistrationNumber = registrationNumber.ToUpperInvariant();
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
