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
                PrintMessage("\nGARAGE - MAIN MENU (Choice 0-5)");
                PrintMessage("" 
                    + "\n1. List all vehicles in the garage"
                    + "\n2. List all vehicle types in the garage"
                    + "\n3. Add vehicle to or Remove vehicle from the garage"
                    + "\n4. Find vehicles in the garage"
                    + "\n5. Create a new garage"
                    + "\n0. Exit the application");
        }

        public static char MenuChoice()
        {
            char input = ' '; //Creates the character input to be used.
            try //Tries to set input to the first char in an input line
            {
                PrintMessage("\nEnter Your Choice: ");
                input = Console.ReadLine()![0]; 
                return input;
            }
            catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
            {
                return ' '; //TODO Maybe change this
            }
        }
        internal static void DisplayUpdateMenu()
        {
            PrintMessage("\nGARAGE - VEHICLE UPDATE MENU (Choice 0-2)");
            PrintMessage(""
                + "\n1. Add vehicle to the garage"
                + "\n2. Remove vehicle from the garage"
                + "\n0. Exit to the Main Menu");
        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void ClearConsole()
        {
            Console.Clear();
        }

        public static string AskForString(string prompt)
        {
            bool success = false;
            string answer;

            do
            {
                Console.Write($"{prompt}:");
                answer = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(answer))
                {
                    Console.WriteLine($"You must enter a valid {prompt}");
                }
                else
                {
                    success = true;
                }

            } while (!success);

            return answer;
        }

        public static int AskForCapacity(string prompt)
        {
            do
            {
                string input = AskForString(prompt);
                if (int.TryParse(input, out int result))
                {
                    if (result > 0)
                    { 
                        return result; 
                    }
                    else
                    { 
                        Console.WriteLine($"Please enter a valid {prompt}"); 
                    }
                }
                else
                {
                    Console.WriteLine($"Please enter a valid {prompt}");
                }


            } while (true);
        }

        public static int AskForPositiveInt(string prompt)
        {
            do
            {
                string input = AskForString(prompt);
                if (int.TryParse(input, out int result))
                {
                    if (result > 0)
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine($"Please enter a valid {prompt}");
                    }
                }
                else
                {
                    Console.WriteLine($"Please enter a valid {prompt}");
                }


            } while (true);
        }

        internal static void DisplayTypeMenu()
        {
            PrintMessage("\nGARAGE - ADD VEHICLE TYPE MENU (Choice 0-2)");
            PrintMessage(""
                + "\n1. Car"
                + "\n2. Bus"
                + "\n3. Motorcycle"
                + "\n0. Exit");
        }
    }
}
