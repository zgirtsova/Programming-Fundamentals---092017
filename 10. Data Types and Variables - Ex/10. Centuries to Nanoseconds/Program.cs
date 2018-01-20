using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            long minutes = hours * 60;
            ulong seconds = (ulong)minutes * 60;
            ulong milliseconds = seconds * 1000;
            decimal microseconds = milliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;
            Console.Write($"{centuries} centuries = ");
            Console.Write($"{years} years = ");
            Console.Write($"{days} days = ");
            Console.Write($"{hours} hours = ");
            Console.Write($"{minutes} minutes = ");
            Console.Write($"{seconds} seconds = ");
            Console.Write($"{milliseconds} milliseconds = ");
            Console.Write($"{microseconds} microseconds = ");
            Console.Write($"{nanoseconds} nanoseconds");
        }
    }
}
