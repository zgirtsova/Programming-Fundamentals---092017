using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Replace_a_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            while (text != "end")
            {
                string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                if (Regex.IsMatch(text, pattern))
                {
                    string replacement = @"[URL href=$1]$2[/URL]";
                    string replaced = Regex.Replace(text, pattern, replacement);
                    Console.WriteLine(replaced);
                }
                else { Console.WriteLine(text); }
                
                text = Console.ReadLine();
            }
        }
    }
}
