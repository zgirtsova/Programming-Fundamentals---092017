using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int cheese = 500;
            int tomatoSauce = 150;
            int salami = 600;
            int pepper = 50;
            int n = int.Parse(Console.ReadLine());
            string ingredient = "";
            int totalCalories = 0;

            for (int i = 0; i < n; i++)
            {
                ingredient = Console.ReadLine();
                ingredient = ingredient.ToLower();

                switch (ingredient)
                {
                    case "cheese":
                        totalCalories += cheese; break;
                    case "tomato sauce":
                        totalCalories += tomatoSauce; break;
                    case "salami":
                        totalCalories += salami; break;
                    case "pepper":
                        totalCalories += pepper; break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
