using Task5.App.Entitites;
using Task5.App.Entitites.Vehicles;
using Task5.App.Interfaces;
using Task5.App.Tools;

namespace Task5.App.UI
{
    internal class UI : IUI
    {
        private readonly GarageHandler<IVehicle> _garageHandler = garageHandler;
        private readonly VehicleFactory _vehicleFactory;

        public UI(GarageHandler<IVehicle> garageHandler, VehicleFactory vehicleFactory)
        {
            _garageHandler = garageHandler;
            _vehicleFactory = vehicleFactory;
        }

        public void DisplayMenu()
        {
            Console.WriteLine($"\nMenu" +
                $"\n1. Park a vehicle" +
                $"\n2. Remove a vehicle" +
                $"\n3. Find a vehicle" +
                $"\n4. List all vehicles" +
                $"\n5. Exit");
            Console.Write("Choose an option: ");
        }

        public void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Garage Management System");
        }

        public int GetGarageCapacity()
        {
            Console.WriteLine("Enter the capacity of the garage: ");
            if (int.TryParse(Console.ReadLine(), out int capacity) && capacity > 0)
            {
                return capacity;
            }
            Console.WriteLine("Invalid input. Please enter a positive integer");
            return GetGarageCapacity();
        }

        public void HandleMenuOption()
        {
            bool exit = false;
            while (!exit)
            {
                DisplayMenu();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddVehicle();
                        break;
                    case "2":
                        RemoveVehicle();
                        break;
                    case "3":
                        FindVehicle();
                        break;
                    case "4":
                        ListAllVehicles();
                        break;
                    case "5":
                        exit = true;
                        Console.WriteLine("Thank you for using Garage Management System");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice. Please select a valid option");
                        break;
                }
            }
        }

        private void RemoveVehicle()
        {
            throw new NotImplementedException();
        }

        private void FindVehicle()
        {
            throw new NotImplementedException();
        }

        private void ListAllVehicles()
        {
            throw new NotImplementedException();
        }

        private void AddVehicle()
        {
            Type[] vehicleTypes = VehicleFactory.GetVehicleTypes();

            Console.WriteLine("Select a vehicle type to add:");
            for (int i = 0; i < vehicleTypes.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {vehicleTypes[i].Name}");
            }

            Console.Write("Enter the number corresponding to the vehicle type");
            if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= vehicleTypes.Length)
            {
                Type selectedType = vehicleTypes[choice - 1];
                IVehicle vehicle = CreateVehicleInstance(selectedType);
                if (vehicle != null)
                {
                    _garageHandler.AddVehicle(vehicle);
                    Console.WriteLine($"{selectedType.Name} added to the garage");
                }
                else
                {
                    Console.WriteLine("Failed to create vehicle");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }

    }
}
