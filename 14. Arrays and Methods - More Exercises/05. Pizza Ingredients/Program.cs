using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split(' ');
            int ingrLen = int.Parse(Console.ReadLine());
            int ingrCount = 0; //when ingrCount == 10 we should stop
            string usedIngr = "";

            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i].Length == ingrLen)
                {
                    ingrCount++;
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    usedIngr += ingredients[i] + " ";
                    if (ingrCount >= 10)
                    {
                        break;
                    }
                }                
            }
            Console.WriteLine($"Made pizza with total of {ingrCount} ingredients.");
            usedIngr = usedIngr.Trim();
            string[] usedIng = usedIngr.Split(' ').ToArray();
            Console.WriteLine($"The ingredients are: {string.Join(", ", usedIng)}.");

        }
    }
}
