using Garage.Garage;
using Garage.GarageHandler;
using Garage.UI;
using Garage.Vehicles;

namespace Garage

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Testcode
            //string?[] s = new string[5];
            //s[0] = "3";
            //s[1] = "7";
            //s[1] = null;
            //Console.WriteLine(s[1]);

            // Initiate app
            ConsoleUI ui = new();
            //GarageHandler.GarageHandler gh = new ();
            ////Testcode
            //var myGarage = new Garage<Vehicle>(9);
            
            //myGarage.AddVehicle(new Car("KKW479", "blue", 4, "Diesel"));
            //myGarage.AddVehicle(new Car("PDS873", "black", 4, "Petrol"));
            //myGarage.AddVehicle(new Car("TRU834", "red", 4, "Petrol"));
            //myGarage.AddVehicle(new Car("UJE345", "silver", 4, "Petrol"));
            //myGarage.AddVehicle(new Motorcycle("IUY234", "red", 2, 750));
            //myGarage.AddVehicle(new Motorcycle("IUY234", "yellow", 2, 125));
            //myGarage.AddVehicle(new Bus("TRU834", "white", 6, 63));
            //myGarage.AddVehicle(new Bus("YTR475", "red", 4, 46));
            //myGarage.AddVehicle(new Bus("UJE345", "green", 4, 52));

            //var query = from v in myGarage
            //            where v.RegistrationID == "KKW479"
            //            select v;

            while (true)
            {
                ui.DisplayMainMenu();
                char input = ui.MenuChoice();

                switch (input)
                {
                    case '1':
                        ConsoleUI.ClearConsole();
                        GarageHandler.GarageHandler.ListAllVehicles();
                        break;
                    case '2':
                        ConsoleUI.ClearConsole();
                        GarageHandler.GarageHandler.ListAllVehicleTypes();
                        break;
                    case '3':
                        ConsoleUI.ClearConsole();
                        GarageHandler.GarageHandler.UpdateVehicles();
                        break;
                    case '4':
                        ConsoleUI.ClearConsole();
                        GarageHandler.GarageHandler.SearchForVehicles();
                        break;
                    case '5':
                        ConsoleUI.ClearConsole();
                        GarageHandler.GarageHandler.CreateNewGarage();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        ConsoleUI.ClearConsole();
                        ConsoleUI.PrintMessage("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }
    }
}
