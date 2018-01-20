using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.___Be_Positive
{
    class Program
    {
        static void Main(string[] args)
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                List<int> numbers = new List<int>();
                List<int> data = new List<int>();

                for (int j = 0; j < input.Length; j++)
                {
                    if (!input[j].Equals(string.Empty))
                    {
                        numbers.Add(int.Parse(input[j]));
                    }
                }

                for (int k = 0; k < numbers.Count; k++)
                {
                    int currentNum = numbers[k];
                    if (currentNum >= 0)
                    {
                        data.Add(currentNum);
                    }
                    else
                    {
                        if (k + 1 < numbers.Count)
                        {
                            currentNum += numbers[k + 1];
                            k++;
                        }
                        //currentNum += numbers[j + 1];

                        if (currentNum >= 0)
                        {
                            data.Add(currentNum);
                        }
                    }                    
                }                

                if (data.Count == 0)
                {
                    Console.WriteLine("(empty)");
                }
                else
                    Console.WriteLine(String.Join(" ", data));
                
            }
        }
    }
}
