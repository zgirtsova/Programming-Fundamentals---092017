using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var max = (input[0].Length >= input[1].Length) ? input[0] : input[1];
            var min = (input[0].Length < input[1].Length) ? input[0] : input[1];
            long output = 0;

            for (int i = 0; i < max.Length; i++)
            {
                if (i < min.Length)
                {
                    output += min[i] * max[i];
                }
                else
                {
                    output += max[i];
                }
            }
            Console.WriteLine(output);


        }
    }
}
