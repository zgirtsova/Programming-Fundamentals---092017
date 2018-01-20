using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();

                switch (command[0])
                {
                    case "Reverse": Array.Reverse(arr); break;
                    case "Distinct": Distinct(arr); break;
                    case "Replace": Replace(arr, int.Parse(command[1]), command[2]); break;

                    default:
                        break;
                }
            }                        
            Console.WriteLine(String.Join(", ", arr.Where(s => !string.IsNullOrEmpty(s))));
        }       

        static void Replace(string[] arr, int index, string word)
        {
            for (int i = index; i < arr.Length; i++)
            {
                if (arr[i] == null)
                {
                    continue;
                }
                else
                {
                    arr[i] = word;
                    break;
                }
            }
        }

        static void Distinct(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length - i; j++)
                {
                    if (arr[i] == arr[i + j])
                    {
                        arr[i + j] = null;
                    }
                }
            }
        }
    }
}
