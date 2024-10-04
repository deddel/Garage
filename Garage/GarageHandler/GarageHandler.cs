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
            if (theGarage != null)
                ConsoleUI.PrintMessage($"{theGarage}");
        }

        public static void ListAllVehicleTypes ()
        {
            theGarage?.ListAllTypes();
            //if (theGarage != null)
            //{
            //    theGarage.ListAllTypes();
            //}
        } 

        public static void UpdateVehicles() 
        {
            bool isUpdating = true;
            while (theGarage != null && isUpdating)
            {
                ConsoleUI.ClearConsole();
                if (theGarage.IsFull) 
                { 
                    ConsoleUI.PrintMessage("The Garage is full. Please remove a vehicle before you can add!"); 
                }
                ConsoleUI.DisplayUpdateMenu();
                char input =  ConsoleUI.MenuChoice();
                string registrationId;
                string color;
                int nrOfWheels;
                string fuelType;
                int seats;
                int cubicCapacity;
                bool isAdding = true;

                switch (input)
                {
                    case '1':
                        while (isAdding)
                        {
                            ConsoleUI.DisplayTypeMenu();
                            if (theGarage.IsFull)
                            {
                                ConsoleUI.PrintMessage("Please remove a vehicle first!");
                                break;
                            }
                            char inp = ConsoleUI.MenuChoice();

                            switch (inp)
                            {
                                case '1': //Car
                                    ConsoleUI.PrintMessage("Please enter the details of the car");
                                    registrationId = ConsoleUI.AskForString("RegistrationID");
                                    color = ConsoleUI.AskForString("Color");
                                    nrOfWheels = ConsoleUI.AskForPositiveInt("Number of wheels");
                                    fuelType = ConsoleUI.AskForString("Fuel type");
                                    theGarage.AddVehicle(new Car(registrationId,color,nrOfWheels,fuelType));
                                    break;
                                case '2': //Bus
                                    ConsoleUI.PrintMessage("Please enter the details of the bus");
                                    registrationId = ConsoleUI.AskForString("RegistrationID");
                                    color = ConsoleUI.AskForString("Color");
                                    nrOfWheels = ConsoleUI.AskForPositiveInt("Number of wheels");
                                    seats = ConsoleUI.AskForPositiveInt("Number of Seats");
                                    theGarage.AddVehicle(new Bus(registrationId, color, nrOfWheels, seats));
                                    break;
                                case '3': //Motorcycle
                                    ConsoleUI.PrintMessage("Please enter the details of the motorcycle");
                                    registrationId = ConsoleUI.AskForString("RegistrationID");
                                    color = ConsoleUI.AskForString("Color");
                                    nrOfWheels = ConsoleUI.AskForPositiveInt("Number of wheels");
                                    cubicCapacity = ConsoleUI.AskForPositiveInt("Cubic Capacity");
                                    theGarage.AddVehicle(new Motorcycle(registrationId, color, nrOfWheels, cubicCapacity));
                                    break;
                                case '0': //Exit
                                    isAdding = false;
                                    break;
                                default:
                                    ConsoleUI.ClearConsole();
                                    ConsoleUI.PrintMessage("Please enter a valid input! (0,1,2,3)");
                                    break;
                            }
                        }
                        break;
                    case '2':
                        registrationId = ConsoleUI.AskForString("RegistrationID: ").ToUpper();
                        theGarage.RemoveVehicle(registrationId);
                        break;
                    case '0':
                        isUpdating = false;
                        break;
                    default:
                        ConsoleUI.PrintMessage("Please enter a valid input! (0,1,2)");
                        break;
                }
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
