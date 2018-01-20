using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 1; j < arr.Length - i; j++)
                {
                    int difference = Math.Abs(arr[i] - arr[i + j]);
                    if (difference == diff)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
