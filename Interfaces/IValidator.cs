using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.App.Interfaces
{
    public interface IValidator
    {
        void ValidateNumberOfWheels(int numberOfWheels);
        void ValidateRegistrationNumber(string registrationNumber);
        void ValidateColor(string color);
    }
}
