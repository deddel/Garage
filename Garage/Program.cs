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
            GarageHandler.GarageHandler gh = new ();
            //Testcode
            var myGarage = new Garage<Vehicle>(5);
            Vehicle myVehicle1 = new Vehicle("TRU834", "red", 4);
            Vehicle myVehicle2 = new Vehicle("YTR475", "blue", 4);
            Vehicle myVehicle3 = new Vehicle("UJE345", "silver", 4);
            Vehicle myVehicle4 = new Vehicle("IUY234", "green", 4);
            myGarage.AddVehicle(myVehicle1);
            myGarage.AddVehicle(myVehicle2);
            //Console.WriteLine(myGarage.IsFull);
            //Console.WriteLine(myGarage.Count);
            //myGarage.AddVehicle(myVehicle3)
            //Console.WriteLine(myGarage.Count);
            //Console.WriteLine(myGarage.IsFull);
            //Console.WriteLine(myGarage.Count);
            //myGarage.AddVehicle(myVehicle4);
            //Console.WriteLine(myGarage.Count);
            Console.WriteLine(myGarage.ToString());
            myGarage.RemoveVehicle("TRU834");
            Console.WriteLine(myGarage.ToString());
            
            
            while (true)
            {
                ui.DisplayMainMenu();
                char input =ui.MenuChoice();

                switch (input)
                {
                    case '1':
                        GarageHandler.GarageHandler.CreateNewGarage(                        GarageHandler.GarageHandler.GetTheGarage());
                        break;
                    case '2':
                        ;
                        break;
                    case '3':
                        ;
                        break;
                    case '4':
                        ;
                        break;
                    case '5':
                        ;
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }
    }
}
