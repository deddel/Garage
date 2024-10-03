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
            var capacity = ConsoleUI.AskForCapacity("Input the capacity (Minimum 9) :");
            theGarage = new Garage<Vehicle>(capacity);
            ConsoleUI.PrintMessage($"Created a new Garage:\n{theGarage}");
        }
        
        public static void ListAllVehicles() 
        {
            ConsoleUI.PrintMessage($"{theGarage}");
        }

        public static void ListAllVehicleTypes ()
        {

            //Metod i Garage
            if (theGarage != null) 
            {
                theGarage.ListAllTypes();
            }
        } 

        public static void UpdateVehicles() 
        {
            //TODO implement
            //Menu i UI
            //Val i UI
            if (theGarage != null)
            {
                theGarage.AddVehicle(new Bus("UJE345", "rosa", 4, 52));
            }
        }

        public static void SearchForVehicles() 
        {
            //TODO Implement
            //Menu i UI
            //Val i UI
            //Metod i Garage
        }









    }
}
