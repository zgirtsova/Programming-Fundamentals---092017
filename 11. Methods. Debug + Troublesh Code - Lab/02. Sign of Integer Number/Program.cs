using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSign(int.Parse(Console.ReadLine()));
        }

        static void PrintSign(int number)
        {
            string posOrNeg = "";
            if (number > 0)
            {
                posOrNeg = "positive";
            }
            else if (number < 0)
            {
                posOrNeg = "negative";
            }
            else
            {
                posOrNeg = "zero";
            }
            Console.WriteLine($"The number {number} is {posOrNeg}.");
        }
    }
}
