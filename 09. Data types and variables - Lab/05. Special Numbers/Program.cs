using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++) // i = 14
            {
                int num = i; // num = 14
                sum = 0;

                while (num != 0)  // 14
                {
                    sum = sum + num % 10; // 4
                    num = num / 10;
                }

                if (sum == 5)
                {
                    Console.WriteLine(i + " True");
                }
                else if (sum == 7)
                {
                    Console.WriteLine(i + " True");
                }
                else if (sum == 11)
                {
                    Console.WriteLine(i + " True");
                }
                else
                {
                    Console.WriteLine(i + " False");
                }
            }
        }
    }
}
