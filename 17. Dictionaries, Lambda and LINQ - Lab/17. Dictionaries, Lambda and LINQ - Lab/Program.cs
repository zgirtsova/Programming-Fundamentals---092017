using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Dictionaries__Lambda_and_LINQ___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split(' ');

            var dict = words.Distinct().ToDictionary(x => x, x => 0);
            foreach (var word in words)
            {
                dict[word]++;                
            }
            
            Console.WriteLine(string.Join(", ", dict.Where
                (x => x.Value % 2 != 0).Select(x => x.Key)));

        }
    }
}
