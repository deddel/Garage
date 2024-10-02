using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garage;
using Garage.Garage;
using Garage.GarageHandler;
using Garage.UI;
using Garage.Vehicles;

namespace Garage.GarageHandler
{
    public class GarageHandler
    {
        public Garage<Vehicle>? TheGarage { get; }

        public static void CreateNewGarage() //Where do I store the Garage-objects? In this class?
        {
            //Call UI members for a menu and choice
            //Create Garage
            //var myGarage = new Garage<Vehicle>(5);
        }
        
        public void ListAllVehicles() //UI+Garage methods
        {

        }

        public void ListAllVehicleTypes () { } //UI+Garage methods

        public void UpdateVehicles() { } //UI+Garage methods

        public void SearchForVehicles() { } //UI+Garage object+LINQ

        







    }
}
