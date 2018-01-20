using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = inputArr.Length;

            while (count > 1)
            {
                for (int i = 0; i < count - 1; i++)
                {
                    inputArr[i] = inputArr[i] + inputArr[i + 1];
                }
                count--;
            }
            Console.WriteLine(inputArr[0]);
        }
    }
}
