using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                output += GetEscapeSequence(input[i]);
            }

            Console.WriteLine(output);
            
            string GetEscapeSequence(char c)
            {
                return "\\u" + ((int)c).ToString("x4");
            }
        }
    }
}
