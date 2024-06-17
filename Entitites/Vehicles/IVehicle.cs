using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.App.Entitites.Vehicles
{
    public interface IVehicle
    {
        int NumberOfWheels { get; protected set; }
        string RegistrationNumber { get; protected set; }
        string Color { get; protected set; }
        public string GetDetails();
    }
}
