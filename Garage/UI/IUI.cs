using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garage.Garage;
using Garage.GarageHandler;
using Garage.UI;
using Garage.Vehicles;

namespace Garage.UI
{
    public interface IUI
    {
        void DisplayMainMenu();

        char MenuChoice();
    }
}
