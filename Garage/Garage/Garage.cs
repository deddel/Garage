using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

        public Garage(int capacity) 
        { 
            this.Vehicles = new Vehicle[capacity];
        }


        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in Vehicles)
            {
                //Do something if needed
                
                yield return item;
            }
        }


    }
}
