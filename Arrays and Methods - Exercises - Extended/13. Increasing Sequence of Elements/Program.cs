using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Increasing_Sequence_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            String isIncresing = "Yes";
            int number = int.MinValue;
            foreach (int num in arr)
            {
                if (num > number)
                {
                    number = num;
                }
                else
                {
                    isIncresing = "No";
                    break;
                }
            }
            Console.WriteLine(isIncresing);
        }
    }
}
