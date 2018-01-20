using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();

            int counter = 0;
            var index = -1;

            while (true)
            {
                index = input.IndexOf(pattern, index + 1);
                if (index == -1)                
                    break;
                counter++;                
            }
            Console.WriteLine(counter);
        }
    }
}
