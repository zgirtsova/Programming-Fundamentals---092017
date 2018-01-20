using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            // an int array of 4k numbers
            int k = input.Length / 4;
            var a = input.Take(k).Reverse();
            var b = input.Reverse().Take(k);
            // rowOne = a + b;
            var rowOne = a.Concat(b).Select(int.Parse).ToArray();
            var rowTwo = input.Skip(k).Take(2 * k).Select(int.Parse).ToArray();
            var sum = rowOne.Select((x, index) => x + rowTwo[index]);

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
