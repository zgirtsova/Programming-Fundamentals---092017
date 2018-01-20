using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            var commands = Console.ReadLine().Split(' ');
            while (commands[0] != "3:1")
            {
                if (commands[0] == "merge")
                {
                    input = Merge(input, commands);
                    //Console.WriteLine(string.Join(" ", input));
                }
                else if (commands[0] == "divide")
                {
                    input = Divide(input, commands);
                    //Console.WriteLine(string.Join(" ", input));

                }
                commands = Console.ReadLine().Split(' ');
            }
            Console.WriteLine(string.Join(" ", input));
        }
        static IEnumerable<string> Split(string str, int size, int partitions)
        {            
            return Enumerable.Range(0, partitions)
                .Select(i => str.Substring(i * size, size));
        }

        static List<string> Divide(List<string> input, string[] commands)
        {
            List<string> divided = new List<string>();
            int index = int.Parse(commands[1]);
            int partitions = int.Parse(commands[2]);

            for (int i = 0; i < input.Count; i++)
            {
                if (i == index)
                {
                    string word = input[i];
                    int size = word.Length / partitions;
                    if (size != 0)
                    {                        
                        List<string> dividedWord = Split(word, size, partitions).ToList();
                        if (word.Length % partitions != 0)
                        {
                            int startIndex = word.Length - word.Length % partitions;
                            string last = word.Substring(startIndex, word.Length % partitions);
                            dividedWord[dividedWord.Count - 1] += last;
                        }
                        for (int j = 0; j < dividedWord.Count; j++)
                        {
                            divided.Add(dividedWord[j]);
                        }
                    }
                    else
                    {
                        List<string> dividedWord = Split(word, 1, word.Length).ToList();

                        for (int j = 0; j < dividedWord.Count; j++)
                        {
                            divided.Add(dividedWord[j]);
                        }
                    }
                }
                else
                {
                    divided.Add(input[i]);
                }
            }
            return divided;
        }

        static List<string> Merge(List<string> input, string[] commands)
        {            
            List<string> merged = new List<string>();

            int startI = ChangeIndex(int.Parse(commands[1]), input.Count);
            int endI = ChangeIndex(int.Parse(commands[2]), input.Count);

                for (int i = 0; i < input.Count; i++)
                {
                    string joined = "";
                    if (i == startI)
                    {
                        for (int j = startI; j <= endI; j++)
                        {
                            joined += input[j];
                        }
                        merged.Add(joined);
                        i += (endI - i);
                    }
                    else
                    {
                        merged.Add(input[i]);
                    }
                }
            return merged;
        }
        //This method will get an index and the max length of the List
        //Then it will change the index if it is outside the boundaries of the array.
        private static int ChangeIndex(int index, int maxLength)
        {
            if (index < 0)
            {
                index = 0;
            }

            if (index >= maxLength)
            {
                index = maxLength - 1;
            }

            return index;
        }

    }
}
