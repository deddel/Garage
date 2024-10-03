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

        public char MenuChoice()
        {
            char input = ' '; //Creates the character input to be used with the switch-case below.
            try //Tries to set input to the first char in an input line
            {
                Console.Write("\nEnter Your Choice (0-5): ");
                input = Console.ReadLine()![0]; 
                return input;
            }
            catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
            {
                
                return ' ';
            }
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
                answer = Console.ReadLine();

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

        public static int AskForInt(string prompt)
        {
            do
            {
                string input = AskForString(prompt);
                if (int.TryParse(input, out int result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine($"Please enter a valid {prompt}");
                }


            } while (true);
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

        public static uint AskForUInt(string prompt)
        {
            do
            {
                string input = AskForString(prompt);
                if (uint.TryParse(input, out uint result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine($"Please enter a valid {prompt}");
                }


            } while (true);
        }
    }


}
