using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            BigInteger numToCheck = factorial % 10;
            factorial /= 10;

            while (numToCheck == 0)
            {
                count++;
                numToCheck = factorial % 10;
                factorial = factorial / 10;
            }
            Console.WriteLine(count);
        }
    }
}
