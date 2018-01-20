using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([A-Za-z]+)(.+)\1";
            Regex rgx = new Regex(pattern);

            MatchCollection matches = rgx.Matches(input);
            

            string[] replacers = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);           

            var max = Math.Max(matches.Count, replacers.Length);

            for (int i = 0; i < max; i++)
            {
                try
                {
                    // lets mak pattern for the word that should be replaced only with lookbehind and lookahead and match only the middle
                    string patt = $@"(?<={matches[i].Groups[1].Value}).+(?={matches[i].Groups[1].Value})";
                   
                    Regex reg = new Regex(patt);
                    // create a string which matches the original pattern. replacer will be used to replace the original match in the input line
                    string replacer = reg.Replace(matches[i].Value, replacers[i]);
                    int startAt = matches[i].Index;
                     input = rgx.Replace(input, replacer, 1, startAt); // The 1 makes the difference - count of times when the replaced str occurs
                }
                catch (Exception)
                {
                    break;
                }                
            }
            Console.WriteLine(input);
        }
    }
}
