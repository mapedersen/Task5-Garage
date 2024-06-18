using Task5.App.Entitites;
using Task5.App.Interfaces;

namespace Task5.App.UI
{
    internal class UI : IUI
    {
        private readonly GarageHandler<IVehicle> _garageHandler;

        public UI(GarageHandler<IVehicle> garageHandler)
        {
            _garageHandler = garageHandler;
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
