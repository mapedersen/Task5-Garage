using Task5.App.Entitites.Vehicles;

namespace Task5.App.Tools
{
    public class VehicleValidator : IValidator
    {
        public void ValidateNumberOfWheels(int numberOfWheels)
        {
            if (numberOfWheels <= 0)
            {
                throw new ArgumentException("Number of wheels must be positive", nameof(numberOfWheels));
            }
        }
        public void ValidateRegistrationNumber(string registrationNumber)
        {
            if (string.IsNullOrEmpty(registrationNumber))
            {
                throw new ArgumentException("Registration number cannot be null or empty", nameof(registrationNumber));
            }
        }
        public void ValidateColor(string color)
        {
            if (string.IsNullOrWhiteSpace(color))
            {
                throw new ArgumentException($"Color cannot be null or whitespace", nameof(color));

            }
        }
        public void ValidateVehicle(int numberOfWheels, string registrationNumber, string color)
        {
            ValidateNumberOfWheels(numberOfWheels);
            ValidateRegistrationNumber(registrationNumber);
            ValidateColor(color);
        }
    }
}