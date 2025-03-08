using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question3
{
    
class MealCardProgram
        {
            static void Main()
            {
                mealcard card = new mealcard("Ahmed");

                card.DisplayBalance();
                card.PurchaseFood(30);
                card.AddPoints(50);
                card.PurchaseFood(150);
                card.DisplayBalance();
            }
        }

    }

