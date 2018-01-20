using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Equal_Sum_After_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOne = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> listTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            // must remove all elements in listTwo that occurs in listOne

            for (int i = 0; i < listOne.Count; i++)
            {
                for (int j = 0; j < listTwo.Count; j++)
                {
                    if (listTwo[j] == listOne[i])
                    {
                        listTwo.RemoveAt(j);
                    }
                }
            }
            int sumOne = listOne.Sum();
            int sumTwo = listTwo.Sum();

            if (sumOne == sumTwo)
            {
                Console.WriteLine($"Yes. Sum: {sumOne}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(sumOne - sumTwo)}");
            }
            
        }
    }
}
