using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            String figureType = Console.ReadLine();

            switch (figureType)
            {
                case "triangle": GetTriangleArea(); break;
                case "square": GetSquareArea(); break;
                case "rectangle": GetReactangleArea(); break;
                case "circle": GetCircleArea(); break;
                default: break;
            }
            // Console.WriteLine($"{result:F2}");
        }

        static void GetCircleArea()
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * (radius * radius);
            Console.WriteLine($"{area:F2}");
        }
        static void GetReactangleArea()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            Console.WriteLine($"{area:F2}");
        }
        static void GetSquareArea()
        {
            double side = double.Parse(Console.ReadLine());
            double area = side * side;
            Console.WriteLine($"{area:F2}");
        }
        static void GetTriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = (side * height) / 2;
            Console.WriteLine($"{area:F2}");
        }
    }
}
