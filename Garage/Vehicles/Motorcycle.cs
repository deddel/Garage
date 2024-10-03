using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garage.Garage;
using Garage.GarageHandler;
using Garage.UI;
using Garage.Vehicles;

namespace Garage.Vehicles
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string registrationId, string color, int nrOfWheels, int cubicCapacity) : base(registrationId, color, nrOfWheels)
        {
            CubicCapacity = cubicCapacity;
        }

        public int CubicCapacity { get; }

        public override string ToString()
        {
            return base.ToString() + $" CC: {CubicCapacity}";
        }
    }
}
