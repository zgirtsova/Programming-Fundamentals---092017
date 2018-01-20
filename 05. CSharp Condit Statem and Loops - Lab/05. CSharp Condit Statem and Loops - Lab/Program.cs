using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CSharp_Condit_Statem_and_Loops___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
