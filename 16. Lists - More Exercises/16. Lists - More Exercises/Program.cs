using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Lists___More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                int currentNum = list[i];

                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] == currentNum)
                    {
                        list.RemoveAt(j);
                        j--;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
