using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camel_s_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int camelBackSize = int.Parse(Console.ReadLine());

            int difference = list.Count - camelBackSize;
            if (difference == 0)
            {
                Console.WriteLine("already stable: " + string.Join(" ", list));
            }
            else
            {
                int rounds = difference / 2;
                while (rounds > 0)
                {
                    list.RemoveAt(0);
                    list.RemoveAt(list.Count - 1);
                    rounds--;
                }
                rounds = difference / 2;
                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine("remaining: " + string.Join(" ", list));
            }
        }
    }
}
