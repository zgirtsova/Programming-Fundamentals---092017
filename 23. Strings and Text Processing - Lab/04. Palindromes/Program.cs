using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' ', ',', '.', '?', '!'}, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> palinfromes = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                if (isPalindrome(input[i]))
                {
                    palinfromes.Add(input[i]);
                }
            }
            Console.WriteLine(string.Join(", ", palinfromes.Distinct().OrderBy(x => x)));
        }

        static bool isPalindrome(string word)
        {
            for (int j = 0; j < word.Length / 2; j++)
            {
                if (word[j] != word[word.Length - j - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
