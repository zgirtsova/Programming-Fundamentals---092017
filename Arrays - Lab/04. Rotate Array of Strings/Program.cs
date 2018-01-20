using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rotate_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] arr = Console.ReadLine().Split(' ').ToArray();
            String[] reversedArr = new string[arr.Length];
            reversedArr[0] = arr[arr.Length - 1];
            for (int i = 1; i < arr.Length; i++)
            {
                reversedArr[i] = arr[i - 1];
            }
            Console.WriteLine(String.Join(" ", reversedArr));
        }
    }
}
