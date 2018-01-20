using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _03.Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger nFact = 1;
            for (int i = 2; i <= n; i++)
            {
                nFact *= i;
            }
            Console.WriteLine(nFact);
        }
    }
}
