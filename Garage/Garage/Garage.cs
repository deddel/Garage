using System;
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
            this.Vehicles[0] = new Vehicle("KKW479", "black", 4);
            this.Vehicles[1] = new Vehicle("PDS873", "black", 4);
        }

        public void AddVehicle(Vehicle v)
        {
            
            if (IsFull)
            {
                Console.WriteLine("The Garage is full!");
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
            for(int i = 0;i < Vehicles.Length; i++)
            {
                if (Vehicles[i].RegistrationId == registrationId)
                {
                    Vehicles[i] = null;
                    break;
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in Vehicles)
            {
                //Do something if needed
                yield return item;
            }
        }
        
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
            return "List of parked cars: \n"+s;
        }

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
