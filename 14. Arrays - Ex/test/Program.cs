using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] distictNumbers = numbers.Distinct().OrderBy(x => x).ToArray();
            int[] repeart = new int[distictNumbers.Length];

            for (int i = 0; i < distictNumbers.Length; i++)
            {
                repeart[i] = numbers.Count(number => number == distictNumbers[i]);
            }
            Console.WriteLine(distictNumbers[repeart.ToList().IndexOf(repeart.First(repeart.Max))]);
        }
    }
}
