using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            list.Sort();
            list.Add(0);
            int counter = 1;
                        
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    counter++;
                }
                else if ((list[i] != list[i + 1]) || (i == list.Count - 2))
                {                
                    Console.WriteLine($"{list[i]} -> {counter}");
                    counter = 1;
                }
            }

        }
    }
}
