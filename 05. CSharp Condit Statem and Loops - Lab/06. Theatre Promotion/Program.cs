using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Boolean firstRange = age >= 0 && age <= 18;
            Boolean secondRange = age > 18 && age <= 64;
            Boolean thirdRange = age > 64 && age <= 122;

            if (firstRange)
            {
                switch (day)
                {
                    case "Weekday": Console.WriteLine("12$"); break;
                    case "Weekend": Console.WriteLine("15$"); break;
                    case "Holiday": Console.WriteLine("5$"); break;
                    default:
                        break;
                }
            }
            else if (secondRange)
            {
                switch (day)
                {
                    case "Weekday": Console.WriteLine("18$"); break;
                    case "Weekend": Console.WriteLine("20$"); break;
                    case "Holiday": Console.WriteLine("12$"); break;
                    default:
                        break;
                }
            }
            else if (thirdRange)
            {
                switch (day)
                {
                    case "Weekday": Console.WriteLine("12$"); break;
                    case "Weekend": Console.WriteLine("15$"); break;
                    case "Holiday": Console.WriteLine("10$"); break;
                    default:
                        break;
                }
            }
            else { Console.WriteLine("Error!"); }

        }
    }
}
