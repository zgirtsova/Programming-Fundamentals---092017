using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Min__Max__Sum__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n] ;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum = {0}", arr.Sum());
            Console.WriteLine("Min = {0}", arr.Min());
            Console.WriteLine("Max = {0}", arr.Max());
            Console.WriteLine("Average = {0}", arr.Average());

        }
    }
}
