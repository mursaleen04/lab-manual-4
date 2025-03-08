using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
   
       
       

class TripProgram
    {
        static void Main()
        {
            Trip trip = new Trip("Lahore", 500, 100, 20);

            Console.WriteLine("Trip Destination: " + trip.Destination);
            Console.WriteLine("Miles per gallon: " + trip.milespergallon());
            Console.WriteLine("Cost per mile: " + trip.costpermile());
        }
    }




} 

 