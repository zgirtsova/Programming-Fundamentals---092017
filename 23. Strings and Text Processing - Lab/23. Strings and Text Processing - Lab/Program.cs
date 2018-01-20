using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Strings_and_Text_Processing___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder builder = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                builder.Append(input[i]);
            }
            Console.WriteLine(builder);
        }
    }
}
