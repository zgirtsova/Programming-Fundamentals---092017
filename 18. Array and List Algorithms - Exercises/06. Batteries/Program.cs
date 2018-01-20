using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Batteries
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();
            List<int> decrementnumbers = new List<int>();
            int lastone = 0;
            while (input != "stop")
            {
                if (input != "bang" && input != "stop")
                {
                    int num = Int32.Parse(input);
                    numbers.Insert(0, num);
                }
                if (input == "bang" && numbers.Count != 0)
                {
                    var sumnumbers = numbers.Sum();
                    var average = sumnumbers / numbers.Count;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == average || numbers[i] < average)
                        {
                            Console.WriteLine("shot {0}", numbers[i]);
                            lastone = numbers[i];
                            numbers.Remove(numbers[i]);
                            break;
                        }
                    }
                    for (int j = 0; j < numbers.Count; j++)
                    {
                        decrementnumbers.Add(numbers[j] - 1);
                    }
                    numbers.Clear();
                    for (int k = 0; k < decrementnumbers.Count; k++)
                    {
                        numbers.Add(decrementnumbers[k]);
                    }

                }
                else if (input == "bang" && numbers.Count == 0)
                {
                    Console.WriteLine("nobody left to shoot! last one was {0}", lastone);
                    return;
                }
                else if (input == "stop" && numbers.Count != 0)
                {
                    Console.WriteLine("survivors: {0}", string.Join(" ", numbers));
                    return;

                }
                else if (input == "stop" && numbers.Count == 0)
                {
                    Console.WriteLine("you shot them all. last one was {0}", lastone);
                    return;
                }
                decrementnumbers.Clear();
                input = Console.ReadLine();
            }
        }
    }
}