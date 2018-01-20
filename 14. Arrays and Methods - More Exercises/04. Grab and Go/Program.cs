using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long n = long.Parse(Console.ReadLine());
            long lastOccurAt = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    lastOccurAt = i;
                }
            }
            long sum = 0;
            
            if (lastOccurAt >= 0)
            {
                int index = (int)lastOccurAt;
                Console.WriteLine(arr.Take(index).Sum());
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
