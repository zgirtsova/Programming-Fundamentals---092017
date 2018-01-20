using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(new int[] { 1, 2, 3, 4, 5, 6 });
            Console.WriteLine(string.Join(" ", list.Where(i => list[i] % 2 == 0)));

        }
    }
}
