using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closest_Two_Points
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
            Point[] points = ReadPoints(); //метода връща масив от точки
            Point[] closestP = FindClosestTwoPoints(points);
            PrintDistance(closestP);
            PrintPoint(closestP[0]);
            PrintPoint(closestP[1]);

        }

        static void PrintPoint(Point point)
        {
            Console.WriteLine($"({point.X}, {point.Y})");
        }
        static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] allPoints = new Point[n];
            for (int i = 0; i < n; i++)
            {
                int[] pointInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Point point = new Point();
                point.X = pointInfo[0];
                point.Y = pointInfo[1];
                allPoints[i] = point;
            }         

            return allPoints;
        }
        static void PrintDistance(Point[] closestP)
        {
            double sideA = Math.Abs(closestP[0].X - closestP[1].X);
            double sideB = Math.Abs(closestP[0].Y - closestP[1].Y);
            double distance = Math.Sqrt(sideA * sideA + sideB * sideB);

            Console.WriteLine($"{distance:f3}"); 
        }
        static Point[] FindClosestTwoPoints(Point[] points)            
        {
            double minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;
            for (int p1 = 0; p1 < points.Length; p1++)
                for (int p2 = p1 + 1; p2 < points.Length; p2++)
                {
                    double distance = CalcDistance(points[p1], points[p2]);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[] { points[p1], points[p2]};
                    }
                }
            return closestTwoPoints;
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
