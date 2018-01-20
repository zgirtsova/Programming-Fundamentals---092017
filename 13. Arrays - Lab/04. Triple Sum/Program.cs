using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool istrue = false;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {                    
                    if (arr.Contains(arr[i] + arr[j]))
                    {
                        istrue = true;
                        Console.WriteLine($"{arr[i]} + {arr[j]} == {arr[i] + arr[j]}");
                    }
                }
            }
            if (!istrue)
            {
                Console.WriteLine("No");
            }
        }
    }
}
