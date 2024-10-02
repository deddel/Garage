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
        //private Garage<Vehicle> theGarage;

        public static Garage<Vehicle>? TheGarage => CreateNewGarage();

        //public static Garage<Vehicle> GetTheGarage()
        //{
        //    return TheGarage;
        //}

        public static Garage<Vehicle> CreateNewGarage() //Where do I store the Garage-objects?
        {
            Garage<Vehicle>  theGarage = new Garage<Vehicle>(5);
            return theGarage;
        }
        
        public void ListAllVehicles() //UI+Garage methods
        {

        }

        public void ListAllVehicleTypes () { } //UI+Garage methods

        public void UpdateVehicles() { } //UI+Garage methods

        public void SearchForVehicles() { } //UI+Garage object+LINQ

        







    }
}
