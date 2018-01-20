using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            FibNumber(int.Parse(Console.ReadLine()));
        }
        static void FibNumber(int n)
        {
            BigInteger firstNumber = 1;
            BigInteger secondNumber = 1;
            BigInteger fibonacci = 0;

            if (n == 0 || n == 1)
            {
                fibonacci = 1;
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    fibonacci = firstNumber + secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = fibonacci;
                }
            }
            Console.WriteLine(fibonacci);
        }
    }
}
