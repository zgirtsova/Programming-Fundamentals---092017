using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                string number = "";
                for (int j = arr[i].Length - 1; j >= 0; j--)
                {
                    number += arr[i][j];
                }
                sum += int.Parse(number);
            }
            Console.WriteLine(sum);
        }
    }
}
