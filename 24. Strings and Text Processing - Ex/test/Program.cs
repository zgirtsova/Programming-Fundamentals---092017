using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = "123";
            var newString = output.PadLeft(6, '0');
            Console.WriteLine(newString);
        }
    }
}
