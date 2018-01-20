using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            String number = Console.ReadLine();
            String newNumber = "";
            for (int i = 0; i < number.Length; i++)
            {
                newNumber += number.ElementAt(number.Length - i - 1);
            }
            Console.WriteLine(newNumber);
        }
    }
}
