using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (true)
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    counter++;
                }
                catch (Exception)
                {
                    Console.WriteLine(counter);
                    break;
                }
            }
        }
    }
}
