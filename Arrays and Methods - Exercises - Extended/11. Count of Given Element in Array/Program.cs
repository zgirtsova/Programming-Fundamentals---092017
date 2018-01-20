using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Count_of_Given_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            int counter = 0;
            foreach (int number in arr)
            {
                if (num == number)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
