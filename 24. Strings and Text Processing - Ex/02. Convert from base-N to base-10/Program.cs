using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            BigInteger baseN = BigInteger.Parse(input[0]);
            BigInteger num = BigInteger.Parse(input[1]);
            BigInteger power = 0;
            BigInteger converted = 0;
            while (num != 0)
            {
                BigInteger digit = num % 10;
                converted += digit * PowerBigInt(baseN, power);
                num = num / 10;
                power++;
            }
            Console.WriteLine(converted);
        }

        static BigInteger PowerBigInt(BigInteger baseN, BigInteger power)
        {
            BigInteger powered = 1;
            for (int i = 0; i < power; i++)
            {
                powered *= baseN;
            }
            return powered;
        }
    }
}
