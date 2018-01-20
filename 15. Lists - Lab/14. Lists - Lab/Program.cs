using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Lists___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> posList = new List<int>(); 
            for (int i = list.Count - 1;i >= 0; i--)
            {
                if (list[i] > 0)
                {
                    posList.Add(list[i]);
                }
            }
            if (posList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", posList));
            }
        }
    }
}
