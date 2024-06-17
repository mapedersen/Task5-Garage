using Task5.App.Interfaces;

namespace Task5.App.Entitites
{
    internal class GarageHandler<T> : IHandler<T> where T : IVehicle
    {
        private readonly IGarage<T> _garage;
        public GarageHandler(IGarage<T> garage)
        {
            _garage = garage;
        }
        public void AddVehicle(T vehicle)
        {
            _garage.Park(vehicle);
        }

        public bool RemoveVehicle(string registrationNumber)
        {
            T vehicle = _garage.Find(registrationNumber);
            if (vehicle != null)
            {
                return _garage.Remove(vehicle);
            }
            return false;
        }

        public T GetVehicle(string registrationNumber)
        {
            return _garage.Find(registrationNumber);
        }

        public IEnumerable<T> GetAllVehicles()
        {
            return _garage;
        }
    }
}
