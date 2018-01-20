using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = GetPowerOfNum(num, power);
            Console.WriteLine(result);
        }
        static double GetPowerOfNum(double num, double power)
        {
            return Math.Pow(num, power);
        }
    }
}
