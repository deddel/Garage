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
    public class Bus : Vehicle
    {
        public Bus(string registrationId, string color, int nrOfWheels, int seats) : base(registrationId, color, nrOfWheels)
        {
            Seats = seats;
        }
        public int Seats {  get; }
        public override string ToString()
        {
            return base.ToString()+$" Seats: {Seats}";
        }
    }
}
