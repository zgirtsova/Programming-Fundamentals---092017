using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvensAndOdds(number));
        }

        static int GetMultipleOfEvensAndOdds(int number)
        {
            return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
        }
        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            int even;
            while (n > 0)
            {
                even = n % 10;
                if (even % 2 != 0)
                {
                    sum += even;
                }
                n = n / 10;
            }
            return sum;
        }
        static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            int odd;
            while (n > 0)
            {
                odd = n % 10;
                if (odd % 2 == 0)
                {
                    sum += odd;
                }
                n = n / 10;
            }
            return sum;
        }
    }
}
