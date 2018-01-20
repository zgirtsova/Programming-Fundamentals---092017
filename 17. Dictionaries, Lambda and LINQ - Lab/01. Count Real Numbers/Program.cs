using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var counts = nums.Distinct().OrderBy(x => x).ToDictionary(x => x, x => 0);

            foreach (var num in nums)
            {
                counts[num]++;                                    
            }
            Console.WriteLine(string.Join("\r\n", counts.Select
                (x => x.Key + " -> " + x.Value)));            
        }
    }
}
