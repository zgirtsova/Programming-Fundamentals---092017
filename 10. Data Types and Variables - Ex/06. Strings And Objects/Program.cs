using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = ("Hello");
            string world = ("World");
            object concat = hello + " " + world;
            string newStr = (string)concat;
            Console.WriteLine(newStr);
        }
    }
}
