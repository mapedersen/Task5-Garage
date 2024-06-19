namespace Task5.App.UI
{
    public class InputHandler
    {
        public (string RegistrationNumber, string Color, int NumberOfWheels) GetCommonVehicleInputs()
        {
            Console.Write("Enter registration number: ");
            string registrationNumber = Console.ReadLine();

            Console.Write("Enter color: ");
            string color = Console.ReadLine();

            Console.Write("Enter number of wheels (0 or more): ");
            if (!int.TryParse(Console.ReadLine(), out int numberOfWheels) || numberOfWheels < 0)
            {
                Console.WriteLine("Invalid number of wheels. Please enter a non-negative integer.");
                return (null, null, -1); // Return default values if invalid input
            }

            return (registrationNumber, color, numberOfWheels);
        }

        public string GetFuelType()
        {
            Console.Write("Enter fuel type (diesel/gasoline): ");
            return Console.ReadLine();
        }

        public int GetGuestCapacity()
        {
            Console.Write("Enter guest capacity: ");
            if (int.TryParse(Console.ReadLine(), out int guestCapacity) && guestCapacity > 0)
            {
                return guestCapacity;
            }
            Console.WriteLine("Invalid guest capacity.");
            return -1; // Default invalid value
        }

        public int GetNumberOfEngines()
        {
            Console.Write("Enter number of engines: ");
            if (int.TryParse(Console.ReadLine(), out int numberOfEngines) && numberOfEngines > 0)
            {
                return numberOfEngines;
            }
            Console.WriteLine("Invalid number of engines.");
            return -1; // Default invalid value
        }
    }
}
