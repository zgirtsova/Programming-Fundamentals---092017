using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0m;

            for (int i = 0; i < n; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}
