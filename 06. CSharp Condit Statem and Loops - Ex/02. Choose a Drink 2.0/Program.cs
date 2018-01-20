using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string proffesion = Console.ReadLine();
            string drink = "";
            double qty = double.Parse(Console.ReadLine());

            switch (proffesion)
            {
                case "Athlete":
                    Console.WriteLine($"The {proffesion} has to pay {qty * 0.7:F2}.");
                    break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine($"The {proffesion} has to pay {qty:F2}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The {proffesion} has to pay {qty * 1.7:F2}.");
                    break;
                default:
                    Console.WriteLine($"The {proffesion} has to pay {qty * 1.2:F2}.");
                    break;
            }
        }
    }
}
