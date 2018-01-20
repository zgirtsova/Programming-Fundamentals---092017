using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numCount; i++)
            {
                int sum = 0;
                int currentNum = i;
                while (currentNum != 0)
                {
                    sum += currentNum % 10;
                    currentNum = currentNum / 10;
                }
                bool toe = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {toe}");
            }
        }
    }
}
