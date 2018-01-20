using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Equal_Sequence_of_Elements_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            String areEqual = "Yes";
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    areEqual = "No";
                    break;
                }
            }
            Console.WriteLine(areEqual);
        }
    }
}
