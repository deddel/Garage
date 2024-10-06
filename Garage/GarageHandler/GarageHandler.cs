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
    public class GarageHandler: IHandler
    {
        

        private static Garage<Vehicle>? theGarage;

        public static Garage<Vehicle>? TheGarage { get => theGarage; set => theGarage = value; }
        
        //Creates a new instance of the Garage with predefined vehicles
        public static void CreateNewGarage() 
        {
            var capacity = ConsoleUI.AskForCapacity("Input the capacity (Minimum 9) :");
            theGarage = new Garage<Vehicle>(capacity);
            ConsoleUI.PrintMessage($"Created a new Garage:\n{theGarage}");
        }
        
        //Display all vehicles and data
        public static void ListAllVehicles() 
        {
            ConsoleUI.ClearConsole();
            if (theGarage == null)
            {
                ConsoleUI.PrintMessage("Please create a garage first!");
            }
            else
            {
                ConsoleUI.PrintMessage($"{theGarage}");
            }
        }
        
        //Display all vehicle types and the number of each
        public static void ListAllVehicleTypes ()
        {
            ConsoleUI.ClearConsole();
            if (theGarage == null)
                ConsoleUI.PrintMessage("Please create a garage first!");
            else
                theGarage?.ListAllTypes();
        }
        
        //Add or remove vehicles 
        public static void UpdateVehicles() 
        {
            ConsoleUI.ClearConsole();
            if (theGarage == null)
                ConsoleUI.PrintMessage("Please create a garage first!");
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
        
        //Search for vehicles on any search terms matching Vehicle properties
        public static void SearchForVehicles() 
        {
            if (theGarage == null)
            {
                ConsoleUI.PrintMessage("There is no garage. Please create a garage first!");
            }
            else
            {
                //take input strings, convert to uppercase and store them in a list
                string[] searchStrings = ConsoleUI.AskForString("Enter search words").Split(' ');
                IEnumerable<string> ucSearchStrings = searchStrings.Select(s => s.ToUpper());
                //Get the matching vehicles
                var query=theGarage?.Search(ucSearchStrings);
                if (query != null) 
                    if (query.Any()) // If there is any match
                    {
                        foreach (var v in query)
                        {
                            //Display matching vehicles
                            ConsoleUI.PrintMessage(v.ToString());
                        }
                    }
                    else
                    {
                        ConsoleUI.PrintMessage("No match");
                    }
            }
        }









    }
}
