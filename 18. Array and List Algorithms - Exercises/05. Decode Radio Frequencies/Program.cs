using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Decode_Radio_Frequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(' ').ToList();
            List<int> occurencies = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


            for (int i = 0; i < occurencies.Count; i++)
            {
                Console.WriteLine($"{words[i]} -> {occurencies[i]} times ({(occurencies[i] * 1.00 / words.Count * 100.00):F2}%)");

            }

        }
    }
}
