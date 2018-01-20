using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a = double.Parse(Console.ReadLine());
            Double b = double.Parse(Console.ReadLine());
            Double area = 0;
            area = a * b;
            Console.WriteLine("{0:F2}", area);
        }
    }
}
