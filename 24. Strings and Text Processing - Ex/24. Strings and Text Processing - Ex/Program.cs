using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _24.Strings_and_Text_Processing___Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToList();
            BigInteger baseN = input[0];
            BigInteger num = input[1];
            List<BigInteger> nums = new List<BigInteger>();

            while (num != 0)
            {
                BigInteger reminder = num % baseN;
                num /= baseN;
                nums.Add(reminder);

            }
            nums.Reverse();
            Console.WriteLine(string.Join("", nums));

        }
    }
}
