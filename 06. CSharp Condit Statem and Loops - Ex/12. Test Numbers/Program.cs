using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;
            Boolean shouldBreak = false;

            for (int i = n; i > 0; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    sum += i * j * 3;
                    counter++;
                    if (sum >= maxSum)
                    {
                        shouldBreak = true;
                        break;
                    }
                }

                if (shouldBreak)
                {
                    break;
                }
            }

            if (sum >= maxSum)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum} >= {maxSum}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
