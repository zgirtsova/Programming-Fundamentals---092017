using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            int totalMins = hours * 60 + mins + 30;

            hours = totalMins / 60;
            if (hours > 23)
            {
                hours = 0;
            }
            mins = totalMins % 60;
            if (mins < 10)
            {
                Console.WriteLine($"{hours}:{mins:D2}");
            }
            else
            {
                Console.WriteLine($"{hours}:{mins}");
            }
        }
    }
}
