using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double lineOneLength = GetLineLength(x1, y1, x2, y2);
            String lineOneResult = GetLengthToCenter(x1, y1, x2, y2);

            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());

            double lineTwoLength = GetLineLength(x1, y1, x2, y2);
            String lineTwoResult = GetLengthToCenter(x1, y1, x2, y2);

            if (lineOneLength >= lineTwoLength)
            {
                Console.WriteLine(lineOneResult);
            }
            else
            {
                Console.WriteLine(lineTwoResult);
            }

        }

        static double GetLineLength(double x1, double y1, double x2, double y2)
        {
            double sideX = x2 - x1;
            double sideY = y2 - y1;
            double result = Math.Sqrt(sideX * sideX + sideY * sideY);
            return result;
        }

        static String GetLengthToCenter(double x1, double y1, double x2, double y2)
        {
            double distance1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double distance2 = Math.Sqrt(x2 * x2 + y2 * y2);
            String result = "";

            if (distance1 <= distance2)
            {
                result = $"({x1}, {y1})({x2}, {y2})";
            }
            else
            {
                result = $"({x2}, {y2})({x1}, {y1})";
            }
            return result;
        }
        // връща готовият резултат в стринг
    }
}
