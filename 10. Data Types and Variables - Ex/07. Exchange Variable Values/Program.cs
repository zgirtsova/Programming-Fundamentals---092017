using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine($"Before:\na = 5\nb = 10");
            Console.WriteLine($"After:\na = 10\nb = 5");
            int tempb = b;
        }
    }
}
