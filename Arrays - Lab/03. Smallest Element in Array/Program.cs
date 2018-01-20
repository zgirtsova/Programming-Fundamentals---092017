using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int minValue = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                }
            }
            Console.WriteLine(minValue);
        }
    }
}
