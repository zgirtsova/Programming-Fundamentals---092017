using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var date = DateTime.ParseExact(input, "d-M-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
