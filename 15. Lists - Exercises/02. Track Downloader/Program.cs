using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Track_Downloader
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> blackListedWords = Console.ReadLine().Split(' ').ToList();
            List<string> fileNames = new List<string>();

            string input = Console.ReadLine();

            while (input != "end")
            {
            bool containsBlackList = false;

                for (int i = 0; i < blackListedWords.Count; i++)
                {
                   if (input.Contains(blackListedWords[i]))
                   {
                        containsBlackList = true;
                        break;
                   }

                }
                if (containsBlackList)
                {
                    input = Console.ReadLine();
                }
                else
                {
                    fileNames.Add(input);
                    input = Console.ReadLine();
                }

            }
            fileNames.Sort();
            Console.WriteLine(string.Join("\n", fileNames));
        }
    }
}
