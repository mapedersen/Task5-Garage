using System.Reflection;
using Task5.App.Entitites.Vehicles;
using Task5.App.Interfaces;
using Task5.App.UI;

namespace Task5.App.Tools
{
    public class VehicleFactory
    {
        private readonly InputHandler _inputHandler;

        public VehicleFactory(InputHandler inputHandler)
        {
            _inputHandler = inputHandler;
        }
        public static Type[] GetVehicleTypes()
        {
            var baseType = typeof(Vehicle);
            var assembly = Assembly.GetAssembly(baseType);
            return assembly?.GetTypes()
                            .Where(t => t.IsSubclassOf(baseType) && !t.IsAbstract)
                            .ToArray() ?? [];
        }

        private IVehicle CreateVehicleInstance(Type vehicleType)
        {
            var commonInputs = _inputHandler.GetCommonVehicleInputs();

            // Check if common inputs are valid
            if (commonInputs.RegistrationNumber == null || commonInputs.Color == null || commonInputs.NumberOfWheels < 0)
            {
                Console.WriteLine("Failed to create vehicle due to invalid common inputs.");
                return null;
            }

            if (vehicleType == typeof(Car))
            {
                Console.Write("Enter fuel type (diesel/gasoline): ");
                string fuelType = Console.ReadLine();
                return new Car(commonInputs.NumberOfWheels, commonInputs.RegistrationNumber, commonInputs.Color, fuelType);
            }

            else if (vehicleType == typeof(Boat))
            {
                Console.Write("Enter guest capacity: ");
                if (int.TryParse(Console.ReadLine(), out int guestCapacity) && guestCapacity > 0)
                {
                    return new Boat(commonInputs.NumberOfWheels, commonInputs.RegistrationNumber, commonInputs.Color, guestCapacity);
                }
                Console.WriteLine("Invalid guest capacity.");
            }

            else if (vehicleType == typeof(Airplane))
            {
                Console.Write("Enter number of engines: ");
                if (int.TryParse(Console.ReadLine(), out int numberOfEngines) && numberOfEngines > 0)
                {
                    return new Airplane(commonInputs.NumberOfWheels, commonInputs.RegistrationNumber, commonInputs.Color, numberOfEngines);
                }
                Console.WriteLine("Invalid number of engines.");
            }

            else if (vehicleType == typeof(Bus))
            {
                Console.Write("Enter number of seats: ");
                if (int.TryParse(Console.ReadLine(), out int numberOfSeats) && numberOfSeats > 0)
                {
                    return new Airplane(commonInputs.NumberOfWheels, commonInputs.RegistrationNumber, commonInputs.Color, numberOfSeats);
                }
                Console.WriteLine("Invalid number of seats.");
            }

            else if (vehicleType == typeof(Motorcycle))
            {
                Console.Write("Enter engine cylinder volume: ");
                if (int.TryParse(Console.ReadLine(), out int cylinderVolume) && cylinderVolume > 0)
                {
                    return new Airplane(commonInputs.NumberOfWheels, commonInputs.RegistrationNumber, commonInputs.Color, cylinderVolume);
                }
                Console.WriteLine("Invalid cylinder volume.");
            }
            return null;
        }
    }
}
