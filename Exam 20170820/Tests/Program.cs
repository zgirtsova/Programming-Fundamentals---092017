using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> power = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                power.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(power.Sum());
            Console.WriteLine((int)power.Average());
        }
    }
}
