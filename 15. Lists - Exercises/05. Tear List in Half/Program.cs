using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Tear_List_in_Half
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> output = new List<int>();

            for (int i = list.Count / 2; i < list.Count; i++)
            {
                int decimals = list[i] / 10;
                int digits = list[i] % 10;
                output.Add(decimals);
                output.Add(list[i - list.Count / 2]);
                output.Add(digits);
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
