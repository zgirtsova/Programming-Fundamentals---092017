using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = array.Length - 1; i >= 0; i--)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
