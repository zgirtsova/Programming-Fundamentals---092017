using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _25.Regular_Expressions__RegEx____Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+?\s[A-Z][a-z]+?\b";
            string input = Console.ReadLine();
            
            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.Write(m.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
