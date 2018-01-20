using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyInput = Console.ReadLine();
            string textInput = Console.ReadLine();

            string patern = $@"^([a-zA-Z]+)[\\|<].+[\\|<]([a-zA-Z]+)$";
            Regex regex = new Regex(patern);

            Match match = regex.Match(keyInput);
            string start = match.Groups[1].Value;
            string end = match.Groups[2].Value;

            string wordPattern = $@"{start}(.*?){end}";
            MatchCollection matchCollection = Regex.Matches(textInput, wordPattern);

            if (matchCollection.Count > 1) //защото група 0 е цялото съвпадение
            {
                foreach (Match item in matchCollection)
                {
                    Console.Write(item.Groups[1].Value);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}
