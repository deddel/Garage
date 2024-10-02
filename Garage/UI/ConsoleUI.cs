using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garage.Garage;
using Garage.GarageHandler;
using Garage.UI;
using Garage.Vehicles;


namespace Garage.UI

{
    public class ConsoleUI: IUI
    {
        public void DisplayMainMenu()
        {
                Console.WriteLine("\nGARAGE - MAIN MENU");
                Console.WriteLine("" 
                    + "\n1. List all vehicles in the garage"
                    + "\n2. List all vehicle types in the garage"
                    + "\n3. Add vehicle to or Remove vehicle from the garage"
                    + "\n4. Find vehicles in the garage"
                    + "\n5. Create a new garage"
                    + "\n0. Exit the application");
        }

        internal char MenuChoice()
        {
            char input = ' '; //Creates the character input to be used with the switch-case below.
            try
            {
                Console.Write("\nEnter Your Choice (0-5): ");
                input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                return input;
            }
            catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
            {
                
                return ' ';
            }
        }
    }
}
