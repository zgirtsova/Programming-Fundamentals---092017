using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Arrays_and_Methods___More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine($"Min = {arr.Min()}");
            Console.WriteLine($"Max = {arr.Max()}");
            Console.WriteLine($"Sum = {arr.Sum()}");
            Console.WriteLine($"Average = {arr.Average()}");
        }
    }
}
