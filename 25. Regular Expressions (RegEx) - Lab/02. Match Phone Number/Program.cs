using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359([\s-])2\1[\d]{3}\1[\d]{4}\b";
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);
            List<string> result = new List<string>(matches.Count);

            foreach (Match m in matches)
            {
                result.Add(m.ToString());
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
