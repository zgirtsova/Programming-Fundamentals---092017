using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            var numArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int i = 0;
            int sum = 0;
            while (i >= 0)
            {
                if (i < numArray.Length)
                {
                    sum += numArray[i];
                    i = i + numArray[i] < numArray.Length ?
                        i + numArray[i] :
                        i - numArray[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
