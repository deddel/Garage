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
            var ui = new UI.ConsoleUI();
            //var myGarage =new Garage<Vehicle>(5);
            //foreach (var vehicle in myGarage) {
            //    Console.WriteLine("test");
            //}
            while (true)
            {
                ui.DisplayMainMenu();
                char input =ui.MenuChoice();

                switch (input)
                {
                    case '1':
                        ;
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
