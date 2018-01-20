using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr4k = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = arr4k.Length / 4;
            int[] foldedArr = new int[k * 2];

            for (int i = 0; i < foldedArr.Length; i++, k--)
            {
                if (i < arr4k.Length / 4)
                {
                    foldedArr[i] = arr4k[k - 1];
                }
                else
                {
                    foldedArr[i] = arr4k[arr4k.Length - 1 + k];
                }
            }

            k = arr4k.Length / 4;

            for (int i = 0; i < foldedArr.Length; i++, k++)
            {
                foldedArr[i] += arr4k[k];
            }
            Console.WriteLine(string.Join(" ", foldedArr));
            
        }
    }
}
