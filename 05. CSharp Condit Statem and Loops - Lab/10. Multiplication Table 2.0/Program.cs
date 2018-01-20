using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int multiplyer = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine($"{num} X {multiplyer} = {num * multiplyer}");
                multiplyer++;
            } while (multiplyer <= 10);
        }
    }
}
