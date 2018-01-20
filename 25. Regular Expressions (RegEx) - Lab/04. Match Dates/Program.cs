using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(?<day>\d{2})([\.\/ -])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";
            var input = Console.ReadLine();
            var dates = Regex.Matches(input, pattern);

            foreach (Match d in dates)
            {
                var day = d.Groups["day"].Value;
                var month = d.Groups["month"].Value;
                var year = d.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }


        }
    }
}
