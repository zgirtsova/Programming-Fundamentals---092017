using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double nightsCount = double.Parse(Console.ReadLine());
            double studio = 0;
            double Double = 0;
            double Suite = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studio = nightsCount * 50;
                    Double = nightsCount * 65;
                    Suite = nightsCount * 75; break;
                case "June":
                case "September":
                    studio = nightsCount * 60;
                    Double = nightsCount * 72;
                    Suite = nightsCount * 82; break;
                case "July":
                case "August":
                case "December":
                    studio = nightsCount * 68;
                    Double = nightsCount * 77;
                    Suite = nightsCount * 89; break;
                default:
                    break;
            }

            if (nightsCount > 7 && (month == "May" || month == "October"))
            {
                studio *= 0.95;
            }
            if (nightsCount > 14 && (month == "June" || month == "September"))
            {
                Double *= 0.90;
            }
            if (nightsCount > 14 && (month == "August" || month == "December" || month == "July"))
            {
                Suite *= 0.85;
            }
            if (nightsCount > 7 && (month == "September" || month == "October"))
            {
                if (month == "September")
                {
                    studio -= 60;
                }
                else
                {
                    studio -= 50 * 0.95;
                }
            }

            Console.WriteLine($"Studio: {studio:F2} lv.");
            Console.WriteLine($"Double: {Double:F2} lv.");
            Console.WriteLine($"Suite: {Suite:F2} lv.");
        }
    }
}
