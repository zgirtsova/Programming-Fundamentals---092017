using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            String parameter = Console.ReadLine();
            double result = 0;

            switch (parameter)
            {
                case "face": result = GetFace(side); break;
                case "space": result = GetSpace(side); break;
                case "volume": result = GetVolume(side); break;
                case "area": result = GetArea(side); break;
                default: break;
            }
            Console.WriteLine($"{result:F2}");
        }

        static double GetArea(double side)
        {
            double cubeArea = 6 * (side * side);
            return cubeArea;
        }
        static double GetVolume(double side)
        {
            double cubeVolume = side * side * side;
            return cubeVolume;
        }
        static double GetSpace(double side)
        {
            double spaceDiagonal = Math.Sqrt(side * side + GetFace(side) * GetFace(side));
            return spaceDiagonal;
        }
        static double GetFace(double side)
        {
            double faceDiagonal = Math.Sqrt(side * side + side * side);
            return faceDiagonal;
            // Console.WriteLine($"{faceDiagonal:F2}");
        }
    }
}
