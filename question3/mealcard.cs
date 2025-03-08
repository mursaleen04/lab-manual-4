using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question3
{
    internal class mealcard
    {
      


        public string StudentName;
        public int Balance;

        public mealcard(string name, int initialBalance = 100)
        {
            StudentName = name;
            Balance = initialBalance;
        }

        public void PurchaseFood(int points)
        {
            if (Balance >= points)
            {
                Balance -= points;
                Console.WriteLine("Food purchased! Remaining balance: " + Balance);
            }
            else
            {
                Console.WriteLine("Not enough balance! Purchase denied.");
            }
        }

        public void AddPoints(int points)
        {
            Balance += points;
            Console.WriteLine("Added " + points + " points. New balance: " + Balance);
        }

        public void DisplayBalance()
        {
            Console.WriteLine(StudentName + "'s Balance: " + Balance);
        }
    }

}
