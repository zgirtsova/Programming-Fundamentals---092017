using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circles_Intersection
{
    class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }
    }
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = ReadCircle();
            Circle c2 = ReadCircle();
            double d = CalcDistance(c1.Center, c2.Center); // distance between the circle centers

            if (d > (c1.Radius + c2.Radius))
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
        static Circle ReadCircle()
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Circle c = new Circle
            {
                Center = new Point
                {
                    X = input[0],
                    Y = input[1],
                },
                Radius = input[2]
            };
            return c;
        }
        static double CalcDistance(Point p1, Point p2)
        {
            double sideA = Math.Abs(p1.X - p2.X);
            double sideB = Math.Abs(p1.Y - p2.Y);
            double distance = Math.Sqrt(sideA * sideA + sideB * sideB);

            return distance;
        }
    }
}
