namespace Task5.App.Interfaces
{
    public interface IGarage<T> : IEnumerable<T> where T : IVehicle
    {
        void Park(T vehicle); // Adds a vehicle to the garage
        bool Remove(T vehicle); // Removes a vehicle from the garage
        T Find(string registrationNumber); // Finds a vehicle by its registration number
        int Capacity { get; } // Maximum number of vehicles the garage can hold
        int Count { get; } // Current number of vehicles in the garage
    }
}
