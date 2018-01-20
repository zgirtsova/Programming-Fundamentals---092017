using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Odd_Numbers_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrInt = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < arrInt.Length; i++)
            {
                if ((i % 2 !=0) && (arrInt[i] % 2 != 0))
                {
                    Console.WriteLine("Index {0} -> {1}", i, arrInt[i]);
                }
            }
        }
    }
}
