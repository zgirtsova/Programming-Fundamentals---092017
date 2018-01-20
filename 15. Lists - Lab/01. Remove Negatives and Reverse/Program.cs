using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            list.RemoveAll(s => s < 0);
            list.Reverse();
            if (list.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
            Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}
