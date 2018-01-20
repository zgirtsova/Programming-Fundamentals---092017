using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int startPos = 0;
            int length = 1;
            int bestPos = 0;
            int bestLen = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    length++;
                    if (length > bestLen)
                    {
                        bestLen = length;
                        bestPos = startPos;
                    }
                }
                else
                {
                    if (length > bestLen)
                    {
                        bestPos = startPos;
                        bestLen = length;
                        startPos = i;
                        length = 1;
                    }
                    else
                    {
                        startPos = i;
                        length = 1;
                    }
                }
            }
            if (length > bestLen)
            {
                bestLen = length;
            }
            for (int i = bestPos; i < bestPos + bestLen; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
