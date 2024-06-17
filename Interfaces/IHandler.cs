using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.App.Interfaces
{
    public interface IHandler<T> where T : IVehicle
    {
        void AddVehicle(T vehicle);
        bool RemoveVehicle(string registrationNumber);
        T GetVehicle(string registrationNumber);
        IEnumerable<T> GetAllVehicles();
    }
}
