using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CSharp_Condit_Statem_and_Loops___Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (Console.ReadLine())
            {
                case "Athlete":
                    Console.WriteLine("Water"); break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine("Coffee"); break;
                case "SoftUni Student":
                    Console.WriteLine("Beer"); break;
                default:
                    Console.WriteLine("Tea");
                    break;
            }
        }
    }
}
