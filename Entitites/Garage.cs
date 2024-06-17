using System.Collections;
using Task5.App.Interfaces;

namespace Task5.App.Entitites
{
    public class Garage<T> : IGarage<T> where T : IVehicle
    {
        private readonly T[] _vehicles;
        private int _currentIndex;

        public int Capacity { get; }
        public int Count => _currentIndex;

        public Garage(int capacity)
        {
            Capacity = capacity;
            _vehicles = new T[Capacity];
            _currentIndex = 0;
        }

        public void Park(T vehicle)
        {
            if (_currentIndex >= Capacity)
            {
                throw new InvalidOperationException("Garage is full");
            }
            _vehicles[_currentIndex++] = vehicle;
        }

        public bool Remove(T vehicle)
        {
            for (int i = 0; i < _currentIndex; i++)
            {
                if (_vehicles[i].Equals(vehicle))
                {
                    _vehicles[i] = _vehicles[--_currentIndex];
                    _vehicles[_currentIndex] = default; // Clear last element
                    return true;
                }
            }
            return false;
        }

        public T Find(string registrationNumber)
        {
            foreach (var vehicle in _vehicles)
            {
                if (vehicle != null && vehicle.RegistrationNumber == registrationNumber)
                {
                    return vehicle;
                }
            }
            return default;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _currentIndex; i++)
            {
                yield return _vehicles[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
