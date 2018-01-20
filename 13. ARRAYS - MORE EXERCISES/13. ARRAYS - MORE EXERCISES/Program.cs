using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ARRAYS___MORE_EXERCISES
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();
            string repeatedThreeTimes = string.Empty;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (arr[i] == arr[i + 1] && arr[i] == arr[i + 2])
                {
                    repeatedThreeTimes = arr[i] + " " + arr[i + 1] + " " + arr[i + 2];
                }
            }
            Console.WriteLine(repeatedThreeTimes);
        }
    }
}
