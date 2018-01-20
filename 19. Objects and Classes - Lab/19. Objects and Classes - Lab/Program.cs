using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Objects_and_Classes___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture =
                new CultureInfo("BG-bg");

            DateTime peterBirthday = new DateTime(1981, 09, 26);
            DateTime mariaBirthday = new DateTime(1995, 6, 14);
            Console.WriteLine("Peter's birth date: {0:d-MMM-yyyy}",
            peterBirthday); // 27-Nov-1996
            Console.WriteLine("Maria's birth date: {0:d-MMM-yyyy}",
            mariaBirthday); // 14-Jun-1995
            Console.WriteLine(peterBirthday.DayOfWeek);

            var mariaAfter18Months = mariaBirthday.AddMonths(18);
            Console.WriteLine("Maria after 18 months: {0:d-MMM-yyyy}",
            mariaAfter18Months); // 14-Dec-1996
            TimeSpan ageDiff = peterBirthday.Subtract(mariaBirthday);
            Console.WriteLine("Maria older than Peter by: {0} days",
            ageDiff.Days); // 532 days

            var randomGen = new Random();
            Console.WriteLine(randomGen.Next(100, 200));
            


        }
    }
}
