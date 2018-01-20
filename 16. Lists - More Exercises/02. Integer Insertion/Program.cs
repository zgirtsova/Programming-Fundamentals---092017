using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Integer_Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                int currentNum = int.Parse(command);
                int firstDigit = currentNum;

                while (firstDigit > 9)
                {
                    firstDigit /= 10;
                }
                list.Insert(firstDigit, currentNum);
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
