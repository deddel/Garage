using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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
        

        private static Garage<Vehicle>? theGarage;

        public static Garage<Vehicle>? TheGarage { get => theGarage; set => theGarage = value; }
        
        public static void CreateNewGarage() 
        {
            var capacity = ConsoleUI.AskForCapacity("Input the capacity > 10:");
            theGarage = new Garage<Vehicle>(capacity);
            ConsoleUI.PrintMessage($"Created a new Garage:\n{GarageHandler.theGarage}");
        }
        
        public static void ListAllVehicles() 
        {
            ConsoleUI.PrintMessage($"{GarageHandler.theGarage}");
        }

        public static void ListAllVehicleTypes () { } //UI+Garage methods

        public static void UpdateVehicles() { } //UI+Garage methods

        public static void SearchForVehicles() { } //UI+Garage object+LINQ

        







    }
}
