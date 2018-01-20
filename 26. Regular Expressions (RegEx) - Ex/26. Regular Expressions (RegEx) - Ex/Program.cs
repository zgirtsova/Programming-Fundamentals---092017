using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _26.Regular_Expressions__RegEx____Ex
{
    class Program
    {
        static void Main(string[] args)
        {
           var s = @"\s[A-Za-z0-9]+[._-]?[\w]+@[a-z][a-z.-]+[.][a-z]+";
            var input = Console.ReadLine();
            var matches = Regex.Matches(input, s);

            foreach (Match m in matches)
            {
                string value = m.Value;
                Console.WriteLine(value.TrimStart(new char[] { ' '}));
            }
        }
    }
}