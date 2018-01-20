using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Nth_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            int count = 0;
            int numAtIndex = 0;

            while (count != index)
            {
                numAtIndex = num % 10;
                num /= 10;
                count++;
            }
            Console.WriteLine(numAtIndex);
        }
    }
}
