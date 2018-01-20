using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            switch (a)
            {
                case "a":
                case "e":
                case "o":
                case "i":
                case "u": Console.WriteLine("vowel"); break;
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9": Console.WriteLine("digit"); break;
                default: Console.WriteLine("other"); break;
            }
        }
    }
}
