using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Ununion_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<int> currentList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                for (int j = 0; j < currentList.Count; j++)
                {
                    bool isRepeating = false;
                    for (int k = 0; k < list.Count; k++)
                    {
                        if (currentList[j] == list[k])
                        {
                            list.RemoveAt(k);
                            k--;
                            isRepeating = true;
                        }
                    }
                    if (!isRepeating)
                    {
                        list.Add(currentList[j]);
                    }
                }                
            }
            list.Sort();
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
