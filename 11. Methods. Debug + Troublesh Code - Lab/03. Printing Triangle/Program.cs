using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                PrintNumsToN(i);
            }
            for (int i = num - 1; i > 0; i--)
            {
                PrintNumsToN(i);
            }
        }

        private static void PrintNumsToN(int digit)
        {
            for (int j = 1; j <= digit; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
