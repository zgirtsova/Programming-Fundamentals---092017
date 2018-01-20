using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int arrLength = inputArr.Length;

            if (arrLength == 1)
            {
                Console.WriteLine($"{{ {inputArr[0]} }}");
            }
            else if (arrLength % 2 == 0)
            {
                Console.WriteLine($"{{ {inputArr[arrLength / 2 - 1]}, {inputArr[arrLength / 2]} }}");
            }
            else
            {
                Console.WriteLine($"{{ {inputArr[arrLength / 2 - 1]}, {inputArr[arrLength / 2]}, {inputArr[arrLength / 2 + 1]} }}");

            }
        }
    }
}
