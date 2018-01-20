using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Count_of_Capital_Letters_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == 1)
                {
                    char letter = char.Parse(arr[i]);
                    if (letter >= 65 && letter <= 90)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
