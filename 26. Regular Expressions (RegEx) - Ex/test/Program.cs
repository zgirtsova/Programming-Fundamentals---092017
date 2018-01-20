using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Regex pattern = new Regex($@"\b[^?.!]*\b{word}\b[^?.!]*");

            string text = Console.ReadLine();

            MatchCollection matches = pattern.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value.Trim());
            }
        }
    }
}
