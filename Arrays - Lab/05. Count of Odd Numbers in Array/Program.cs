using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Count_of_Odd_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrInt = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < arrInt.Length; i++)
            {
                if (arrInt[i] % 2 != 0)
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
