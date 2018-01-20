using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bestNum = 0;
            bool hasMatch = false;
            for (int i = 0; i < arr.Length; i++)
            {
                int leftsum = SumLeft(i, arr);
                int rightsum = SumRight(i, arr);
                if (leftsum == rightsum)
                {
                    bestNum = i;
                    hasMatch = true;
                    break;
                }
            }
            if (hasMatch)
            {
                Console.WriteLine(bestNum);
            }
            else { Console.WriteLine("no"); }
        }

        static int SumRight(int num, int[] arr)
        {
            int sumResultRight = 0;
            for (int i = num + 1; i < arr.Length; i++)
            {
                sumResultRight += arr[i];
            }
            return sumResultRight;
        }

        static int SumLeft(int num, int[] arr)
        {
            int sumResultLeft = 0;
            for (int i = 0; i < num; i++)
            {
                sumResultLeft += arr[i];
            }
            return sumResultLeft;
        }
    }
}
