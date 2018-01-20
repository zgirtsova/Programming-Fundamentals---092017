using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = int.Parse(Console.ReadLine());
            string hexValue = Convert.ToString(myInt, 16);
            string binary = Convert.ToString(myInt, 2);

            Console.WriteLine(hexValue.ToUpper());
            Console.WriteLine(binary);
        }
    }
}
