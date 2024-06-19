using Microsoft.VisualBasic.FileIO;
using Task5.App.Entitites.Vehicles;

namespace Task5.App.Validation
{
    public class CarValidator
    {
        public static void ValidateFuelType(string fuelType)
        {
            if (string.IsNullOrWhiteSpace(fuelType))
            {
                throw new ArgumentNullException($"Fueltype cannot be null or empty", nameof(fuelType));
            }

            if (fuelType.ToLower() != "diesel" && fuelType.ToLower() != "gasoline")
            {
                throw new ArgumentException($"Fueltype can only be set to diesel or gasoline", nameof(fuelType));
            }
        }
    }
}
