using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Methods.Debug___Troublesh_Code___Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            sayHello(Console.ReadLine());
        }

        static void sayHello(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
