using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderRow(n);

            for (int i = 0; i < n - 2; i++)
            {
                PrintMiddleRow(n);
            }
            PrintHeaderRow(n);
        }
        static void PrintMiddleRow(int num)
        {
            Console.Write('-');
            for (int i = 1; i < num; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }
        static void PrintHeaderRow(int num)
        {
            Console.WriteLine(new string('-', 2 * num));
        }
    }
}
