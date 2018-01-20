using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Array_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrStr = Console.ReadLine().Split(' ').ToArray();
            List<string> words = new List<string>();
            List<int> occurencies = new List<int>();
            int wordListIterations = -1;

            FindOccurencies(arrStr, words, occurencies, wordListIterations);

            // sort in descending both lists

            SortDescending(words, occurencies);
                        
            for (int i = 0; i < occurencies.Count; i++)
            {
                Console.WriteLine($"{words[i]} -> {occurencies[i]} times ({(occurencies[i] * 1.0 / arrStr.Length * 100.00):F2}%)");
            }           

        }

        static void SortDescending(List<string> words, List<int> occurencies)
        {
            while (true)
            {
                bool isSwapped = false;
                for (int i = 0; i < words.Count - 1; i++)
                {
                    if (occurencies[i] < occurencies[i + 1])
                    {
                        int temp = occurencies[i];
                        occurencies[i] = occurencies[i + 1];
                        occurencies[i + 1] = temp;

                        string temporary = words[i];
                        words[i] = words[i + 1];
                        words[i + 1] = temporary;

                        isSwapped = true;
                    }
                }
                if (!isSwapped)
                {
                    break;
                }
            }
        }
        static void FindOccurencies(string[] arrStr, List<string> words, List<int> occurencies, int wordListIterations)
        {
            for (int i = 0; i < arrStr.Length; i++)
            {
                if (!words.Contains(arrStr[i]))
                {
                    wordListIterations++;
                    words.Add(arrStr[i]);
                    occurencies.Add(1);
                }
                else
                {
                    int index = words.IndexOf(arrStr[i]);
                    occurencies[index]++;
                }
            }            
        }
    }
}
