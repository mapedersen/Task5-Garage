using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Entitites
{
    public interface IVehicle
    {
        int NumberOfWheels { get; set; }
        string RegistrationNumber { get; set; }
        string Color { get; set; }
        public string GetDetails();
    }
}
