using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Min_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMin(GetMin(firstNum, secondNum), thirdNum));
        }

        static int GetMin(int a, int b)
        {
            if (a > b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
    }
}
