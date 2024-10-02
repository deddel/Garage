using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Garage.Garage;
using Garage.GarageHandler;
using Garage.UI;
using Garage.Vehicles;

namespace Garage.Vehicles
{
    public class Vehicle: IVehicle
    {
        private string registrationId;

        private string color;

        private int nrOfWheels;

        public Vehicle(string registrationId, string color, int nrOfWheels) 
        { 
            this.registrationId = registrationId;
            this.color = color;
            this.nrOfWheels = nrOfWheels;
        }

        public string RegistrationId { get { return registrationId; } }
        public string Color { get { return color; } }
        public int NrOfWheels { get { return nrOfWheels; } }

        public override string ToString() => $"RegistrationID: {RegistrationId} " +
            $"Color: {Color} Number of wheels: {NrOfWheels}";
    }
}
