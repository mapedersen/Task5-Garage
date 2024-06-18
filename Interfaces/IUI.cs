using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.App.Interfaces
{
    internal interface IUI
    {
        void DisplayWelcomeMessage();
        int GetGarageCapacity();
        void DisplayMenu();
        void HandleMenuOption();
    }
}
