using Task5.App.Interfaces;

namespace Task5.App.Validation
{
    public class Validator : IValidator
    {
        // Validates that a number is positive
        public static void ValidatePositiveNumber(int value, string propertyName)
        {
            // Implementation
        }

        // Validates that a string is not null or empty
        public static void ValidateNonEmptyString(string value, string propertyName)
        {
            // Implementation
        }

        // Validates the fuel type for a car
        public static void ValidateCarFuelType(string fuelType)
        {
            // Implementation
        }

        public void ValidateNumberOfWheels(int numberOfWheels)
        {
            throw new NotImplementedException();
        }

        public void ValidateRegistrationNumber(string registrationNumber)
        {
            throw new NotImplementedException();
        }

        public void ValidateColor(string color)
        {
            throw new NotImplementedException();
        }
    }
}
