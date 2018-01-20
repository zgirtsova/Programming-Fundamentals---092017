using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            list = list.Take(arr[0]).Skip(arr[1]).ToList();

            if (list.Contains(arr[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
