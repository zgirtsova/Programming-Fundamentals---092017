using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Lists___Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            List<string> newList = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 != 0)
                {
                    newList.Add(list[i]);
                    Console.Write(list[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
