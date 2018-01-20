using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            double altitude = double.Parse(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                if (i % 2 != 0 && arr[i] == "up")
                {
                    altitude += double.Parse(arr[i + 1]);
                }
                else if (i % 2 != 0 && arr[i] == "down")
                {
                    altitude -= double.Parse(arr[i + 1]);
                    if (altitude <= 0)
                    {
                        break;
                    }
                }
            }
            if (altitude > 0)
            {
                Console.WriteLine($"got through safely. current altitude: {altitude}m");
            }
            else
            {
                Console.WriteLine("crashed");
            }
        }
    }
}
