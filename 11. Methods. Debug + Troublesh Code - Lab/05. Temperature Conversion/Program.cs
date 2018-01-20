using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double celsius = ConvertFahrenheitToCelsius(input);
            Console.WriteLine($"{celsius:F2}");
        }

        static double ConvertFahrenheitToCelsius(double input)
        {
            return (input - 32) * 5 / 9;
        }
    }
}
