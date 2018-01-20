using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Data_types_and_variables___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)Math.Round((double)years * 365.2422);
            long hours = days * 24;
            decimal minutes = hours * 60;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes.",
                              centuries, years, days, hours, minutes);
        }
    }
}
