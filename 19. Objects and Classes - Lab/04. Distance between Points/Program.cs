using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_between_Points
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();

            double distance = CalcDistance(p1, p2);

            Console.WriteLine($"Distance: {distance:f3}");

        }

        static double CalcDistance(Point p1, Point p2)
        {
            double sideA = Math.Abs(p1.X - p2.X);
            double sideB = Math.Abs(p1.Y - p2.Y);
            double distance = Math.Sqrt(sideA * sideA + sideB * sideB);

            return distance;
        }

        static Point ReadPoint()
        {
            int[] pointInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point point = new Point();
            point.X = pointInfo[0];
            point.Y = pointInfo[1];

            return point;
        }
    }
}
