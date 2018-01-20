using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var dict = new SortedDictionary<string, string>();

            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "A": AddNumber(input[1], input[2], dict); break;
                    case "S": SearchNum(input[1], dict); break;
                    case "ListAll": PrintAll(dict); break;
                    default:
                        break;
                }
                input = Console.ReadLine().Split(' ');
            }
        }

        static void PrintAll(SortedDictionary<string, string> dict)
        {
            Console.WriteLine(string.Join("\r\n", dict.
                Select(x => x.Key + " -> " + x.Value)));
        }

        static void SearchNum(string name, SortedDictionary<string, string> dict)
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

        static void AddNumber(string name, string number, SortedDictionary<string, string> dict)
        {
            dict[name] = number;
        }

    }
}
