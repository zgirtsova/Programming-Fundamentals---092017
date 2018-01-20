using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energyContent = double.Parse(Console.ReadLine());
            var sugarContent = double.Parse(Console.ReadLine());
            double kcal = volume * energyContent / 100;
            double sugars = volume * sugarContent / 100;

            Console.WriteLine("{0}ml {1}:\n{2}kcal, {3}g sugars", volume, name, kcal, sugars);
        }
    }
}
