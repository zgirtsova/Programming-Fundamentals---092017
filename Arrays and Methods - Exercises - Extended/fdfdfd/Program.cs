using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdfdfd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int maxInt = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] > maxInt)
                {
                    maxInt = arr[i];
                }
            }
            Console.WriteLine(maxInt);

        }
    }
}
