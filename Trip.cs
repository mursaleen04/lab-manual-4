using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
    internal class Trip
    {
    
        public string Destination;
        public double distancetraveled;
        public double totalcostgasoline;
        public double gallonsconsumed;

        public Trip(string destination, double distance, double cost, double gallons)
        {
            Destination = destination;
            distancetraveled = distance;
            totalcostgasoline = cost;
            gallonsconsumed = gallons;
        }

        public double milespergallon()
        {
            return distancetraveled / gallonsconsumed;
        }

        public double costpermile()
        {
            return totalcostgasoline / distancetraveled;
        }
    }

}

