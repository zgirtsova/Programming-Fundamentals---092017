using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[26];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (char)(i + 97);
            }
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine($"{word[i]} -> {Array.IndexOf(arr, word[i])}");
            }
        }
    }
}
