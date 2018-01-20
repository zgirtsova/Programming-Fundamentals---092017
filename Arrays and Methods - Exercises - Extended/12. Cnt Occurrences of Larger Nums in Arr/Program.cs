using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Cnt_Occurrences_of_Larger_Nums_in_Arr
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double p = double.Parse(Console.ReadLine());
            int counter = 0;
            foreach (double num in arr)
            {
                if (num > p)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
