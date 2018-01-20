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
            int n = int.Parse(Console.ReadLine());

            while (n != 1)
            {
                Console.WriteLine(n % 10);
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
