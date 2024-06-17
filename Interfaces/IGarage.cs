namespace Task5.App.Interfaces
{
    public interface IGarage<T> : IEnumerable<T> where T : IVehicle
    {
        void Park(T vehicle);
        bool Remove(T vehicle);
        T Find(string registrationNumber);
        int Capacity { get; }
        int Count { get; }
    }
}
