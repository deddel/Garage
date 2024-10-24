﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Garage.Garage;
using Garage.GarageHandler;
using Garage.UI;
using Garage.Vehicles;

namespace Garage.Garage
{
    public class Garage<T> where T : Vehicle
    {
        private Vehicle[] Vehicles;
        
        public int Count => Counter();

        public bool IsFull => Counter() == Vehicles.Length;

        public Garage(int capacity) 
        { 
            this.Vehicles = new Vehicle[capacity];
            SeedData();
        }

        private void SeedData()
        {
            this.Vehicles[0] = new Car("KKW479", "blue", 4, "Diesel");
            this.Vehicles[1] = new Car("PDS873", "silver", 4, "Petrol");
            this.Vehicles[2] = new Car("TRU834", "red", 4, "Petrol");
            this.Vehicles[3] = new Car("WKK863", "black", 4, "Petrol");
            this.Vehicles[4] = new Motorcycle("IUY234", "red", 2, 750);
            this.Vehicles[5] = new Motorcycle("TOR734", "yellow", 2, 125);
            this.Vehicles[6] = new Bus("TRU834", "white", 6, 63);
            this.Vehicles[7] = new Bus("YTR475", "red", 6, 46);
            this.Vehicles[8] = new Bus("UJE348", "green", 4, 52);
        }

        public void AddVehicle(Vehicle v)
        {
            
            if (IsFull)
            {
                ConsoleUI.PrintMessage("The Garage is full!"); 
            }
            else
            {
                for (int i = 0; i < Vehicles.Length; i++)
                {
                    if (Vehicles[i] == null)
                    {
                        this.Vehicles[i] = v;
                        break;
                    }
                }

            }    
        }

        public void RemoveVehicle(string registrationId)
        {
            if (Vehicles != null)
            {
                bool isFound = false;
                for (int i = 0; i < Vehicles.Length; i++)
                {
                    if (Vehicles[i].RegistrationId == registrationId)
                    {
                        Vehicles[i] = null;
                        isFound = true;
                        break;
                    }
                }
                if (!isFound)
                    ConsoleUI.PrintMessage($"RegistrationID {registrationId} is not in the garage!");
            }
        }
        //Display Vehicle types and their number
        public void ListAllTypes()
        {
            var q = Vehicles
                    .Where(v => v != null)
                    .GroupBy(p => p?.GetType().Name ?? null);

            foreach (var type in q)
            {
                ConsoleUI.PrintMessage($"{type.Key} : Count {type.Count()}");
            }
        }

        //Search method using a collection of user input strings
        //Returns a collection of matching vehicles
        public IEnumerable<Vehicle> Search(IEnumerable<string> searchString)
        {
            var query = Vehicles
            .Where(v => v != null)
            .Where(v => searchString.Any(y => 
                v.RegistrationId.Equals(y) ||
                v.Color.Equals(y) ||
                v.NrOfWheels.ToString().Equals(y) ||
                v.GetType().Name.ToUpper().Equals(y)
                ));
            return query;
        }

        //GetEnumerator to be able to use foreach on instances
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in Vehicles)
            {
                //Do something if needed
                yield return item;
            }
        }
        
        //Display all items in the Garage
        public override string ToString() 
        {
            string s = "";
            foreach(T item in Vehicles)
            {
                if (item != null)
                {
                    s = s + "\n" + item.ToString();
                }
            }
            return "List of parked vehicles: \n"+s;
        }

        //Count number vehicles in the Garage
        public int Counter()
        {
            int count = 0;
            foreach (T item in Vehicles)
            {
                if (item != null)
                {
                    count ++;
                }
            }
            return count;
        }
    }
}
