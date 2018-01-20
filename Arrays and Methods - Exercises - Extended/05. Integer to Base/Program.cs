using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Integer_to_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            Integer_to_Base(number, toBase);
        }

        static void Integer_to_Base(int number, int toBase)
        {
            string result = "";
            while (number > 0)
            {
                result = (number % toBase) + result;
                number /= toBase;
            }
            Console.WriteLine(result);
        }
    }
}
