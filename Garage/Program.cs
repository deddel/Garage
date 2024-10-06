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
            
            // Initialize UI
            ConsoleUI ui = new();

            while (true)
            {
                ui.DisplayMainMenu(); 
                
                char input = ConsoleUI.MenuChoice(); // Get menu choice 

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
                        ConsoleUI.PrintMessage("Please enter some valid input! (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }
    }
}
