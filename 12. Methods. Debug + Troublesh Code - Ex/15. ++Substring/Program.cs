using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.__Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'p')
                {
                    hasMatch = true;
                    int endIndex = i + jump + 1;
                    if (endIndex >= text.Length)
                    {
                        string finalmatchedString = text.Substring(i, text.Length - i);
                        Console.WriteLine(finalmatchedString);
                    }
                    else
                    {
                        string matchedString = text.Substring(i, jump + 1);
                        Console.WriteLine(matchedString);
                    }
                    i += jump;

                }
            }
            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
