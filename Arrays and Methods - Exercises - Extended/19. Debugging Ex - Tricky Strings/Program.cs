using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Debugging_Ex___Tricky_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int numberOfStrings = int.Parse(Console.ReadLine());
            string result = string.Empty;
            string currentString = string.Empty;
            for (int i = 0; i < numberOfStrings - 1; i++)
            {
                currentString = Console.ReadLine();
                result += currentString + delimiter;
            }
            result += Console.ReadLine();
            Console.WriteLine(result);
        }
    }
}
