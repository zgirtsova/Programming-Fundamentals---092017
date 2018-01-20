using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Lists___Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int bestStart = 0;
            int bestLength = 1;
            int startPos = 0;
            int startLen = 1;

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == list[i - 1])
                {
                    startLen++;
                }
                else
                {
                    startPos = i;
                    startLen = 1;
                }
                if (startLen > bestLength)
                {
                    bestLength = startLen;
                    bestStart = startPos;
                }
            }
            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(list[i] + " ");
            }            
        }
    }
}
