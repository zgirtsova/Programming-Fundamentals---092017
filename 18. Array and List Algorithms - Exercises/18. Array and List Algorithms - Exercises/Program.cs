using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Array_and_List_Algorithms___Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> list = new List<int>();
            int lastRemovedInt = 0;
            
            while (input != "stop")
            {
                if (input != "bang") // if it's not bang, then it's integer
                {
                    list.Insert(0, int.Parse(input));
                }
                else
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("nobody left to shoot! last one was " + lastRemovedInt);
                        return;
                    }
                    RemoveBelowAverageAndDecrementAll(ref list, ref lastRemovedInt);
                }
                input = input = Console.ReadLine();                
            }
            if (list.Count == 0)
            {
                Console.WriteLine("you shot them all. last one was " + lastRemovedInt);
            }
            else
            {
                Console.WriteLine("survivors: " + string.Join(" ", list));
            }
        }

        private static void RemoveBelowAverageAndDecrementAll(ref List<int> list, ref int lastRemovedInt)
        {
            double averageValueList = list.Sum() * 1.0 / list.Count * 1.0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] <= averageValueList)
                {
                    lastRemovedInt = list[i];
                    Console.WriteLine($"shot {list[i]}");
                    list.RemoveAt(i);
                    break;
                }
            }
            list = list.Select(x => x - 1).ToList();  //decrement all values by 1
        }
    }
}
