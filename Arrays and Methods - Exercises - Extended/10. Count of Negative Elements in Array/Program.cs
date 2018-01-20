using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Count_of_Negative_Elements_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int countOfNegatives = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] < 0)
                {
                    countOfNegatives++;
                }
            }
            Console.WriteLine(countOfNegatives);
        }
    }
}
