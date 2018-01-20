using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Objects_and_Classes___Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(),
                "d-M-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(),
                "d-M-yyyy", CultureInfo.InvariantCulture);

            List<DateTime> officialHolidays = GetHolidaysBG();
            int holidays = 0;

            for (var i = startDate.Date; i <= endDate.Date;i = i.AddDays(1))
            {
                bool isSaturday = (i.DayOfWeek == DayOfWeek.Saturday);
                bool isSunday = (i.DayOfWeek == DayOfWeek.Sunday);
                bool isOfficalHoliday = isOfficialHoli(i, officialHolidays);

                if (!isSaturday && !isSaturday && !isOfficalHoliday)
                {
                    holidays++;
                }
            }
            Console.WriteLine(holidays);
        }


        static bool isOfficialHoli(DateTime i, List<DateTime> officialHolidays)
        {
            int curDay = i.Day;
            int curMonth = i.Month;

            for (int date = 0; date < officialHolidays.Count; date++)
            {
                int hDay = officialHolidays[date].Day;
                int hMonth = officialHolidays[date].Month;
                if (curDay == hDay && curMonth == hMonth)
                {
                    return true;
                }
            }

            return false;
        }

        static List<DateTime> GetHolidaysBG()
        {
            List<DateTime> holidays = new List<DateTime>(11);
            holidays.Add(new DateTime(2017, 01, 01));
            holidays.Add(new DateTime(2017, 03, 03));
            holidays.Add(new DateTime(2017, 05, 01));
            holidays.Add(new DateTime(2017, 05, 06));
            holidays.Add(new DateTime(2017, 05, 24));
            holidays.Add(new DateTime(2017, 09, 06));
            holidays.Add(new DateTime(2017, 09, 22));
            holidays.Add(new DateTime(2017, 11, 01));
            holidays.Add(new DateTime(2017, 12, 24));
            holidays.Add(new DateTime(2017, 12, 25));
            holidays.Add(new DateTime(2017, 12, 26));
            return holidays;
        }
    }
}
