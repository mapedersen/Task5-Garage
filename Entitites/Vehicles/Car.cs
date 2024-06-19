using Task5.App.Validation;

namespace Task5.App.Entitites.Vehicles
{
    public class Car : Vehicle
    {
        public string FuelType { get; set; }
        public Car(int numberOfWheels, string registrationNumber, string color, string fuelType) : base(numberOfWheels, registrationNumber, color)
        {
            // The base constructor already validates common properties
            // This is validation for the unique car property fuelType.
            CarValidator.ValidateFuelType(fuelType);
            FuelType = fuelType;
        }
    }
}
