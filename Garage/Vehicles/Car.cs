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
    public class Car : Vehicle
    {
        public Car(string registrationId, string color, int nrOfWheels, string fuelType) : base(registrationId, color, nrOfWheels)
        {
            FuelType = fuelType.ToUpper();
        }

        public string FuelType { get; }

        public override string ToString()
        {
            return base.ToString() + $" Fuel Type: {FuelType}";
        }
    }
}
