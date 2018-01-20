using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] givenDelimiters = { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
            // .Split разделя стринг по зададени разделители, които могат да са повече и се 
            // слагат в масив от char-ове. 
            // В .Split след разделителя се слага ,StringSplitOptions.RemoveEmptyEntries
            // което премахва празните стрингове

            List<string> input = Console.ReadLine().Split(givenDelimiters, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                if (IsLowerCase(input[i]))
                {
                    lowerCase.Add(input[i]);
                }
                else if (IsUpperCase(input[i]))
                {
                    upperCase.Add(input[i]);
                }
                else
                {
                    mixedCase.Add(input[i]);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }

        static bool IsUpperCase(string input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 65 && input[i] <= 90)
                {
                    counter++;
                }
            }
            if (counter == input.Length)
                 { return true;  }
            else { return false; }
        }
        static bool IsLowerCase(string input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 97 && input[i] <= 122)
                {
                    counter++;
                }
            }
            if (counter == input.Length)
            { return true; }
            else { return false; }
        }
    }
}
