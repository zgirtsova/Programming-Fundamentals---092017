using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            var input = Console.ReadLine();

            var matches = Regex.Matches(input, pattern);
            foreach (Match m in matches)
            {
                Console.Write(m.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
