using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Dictionaries__Lambda_and_LINQ___Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var dict = new Dictionary<string, string>();

            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "A": AddNumber(input[1], input[2], dict); break;
                    case "S": SearchNum(input[1], dict); break;
                    default:
                        break;
                }
                input = Console.ReadLine().Split(' ');
            }
        }

        static void SearchNum(string name, Dictionary<string, string> dict)
        {
            try
            {
                Console.WriteLine($"{name} -> {dict[name]}");
            }
            catch (Exception)
            {
                Console.WriteLine($"Contact {name} does not exist.");
            }
        }

        static void AddNumber(string name,string number,Dictionary<string, string> dict)
        {
            dict[name] = number;            
        }
    }
}
