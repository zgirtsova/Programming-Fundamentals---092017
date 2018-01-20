using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            var difference = Math.Abs(a - b);

            const double precision = 0.000001;
            if (difference < precision)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
