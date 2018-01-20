using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int n = arr.Length;
            int[] sumArr = new int[n];

            for (int rounds = 1; rounds <= k; rounds++)
            {
                for (int i = 0; i < n; i++)
                {
                    int currentElPosition = (i + rounds) % n;
                    //изчислява елементът i от основния масив (arr), на коя
                    //позиция се намира(currentElPosition) след round брой завъртания 
                    sumArr[currentElPosition] += arr[i];
                }
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
