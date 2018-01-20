using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            array[0] = 1;

            // Enter two integers n and k. 
            // Generate and print the following sequence of n elements:
            // * The first element is: 1
            // * All other elements = sum of the previous k elements
            // (if less than k are available, sum all of them)
            // for n = 9 && k = 5, result is: 1 1 2 4 8 16 31 61 120

            for (int i = 0; i < array.Length; i++)
            {
                for (long j = i - k; j < i; j++)
                {
                    try
                    {
                        array[i] = array[i] + array[j];
                    }
                    catch (IndexOutOfRangeException)
                    { }
                }                
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
