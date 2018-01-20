using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < arr.Length / 2; i++)
            {
                string tempValue = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = tempValue;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
