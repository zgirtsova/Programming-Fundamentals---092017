using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Entertrain
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxPower = int.Parse(Console.ReadLine());
            List<int> wagons = new List<int>();
            string input = Console.ReadLine();

            while (input != "All ofboard!")
            {     
                int wagon = int.Parse(input);
                wagons.Add(wagon);

                if (wagons.Sum() > maxPower)
                {
                    int average = (int)wagons.Average();
                    wagons.RemoveAt(FindIndexToRemove(wagons, average));
                }                
                input = Console.ReadLine();
            }
            wagons.Reverse();
            Console.WriteLine(string.Join(" ", wagons) + " " + maxPower);
        }

        static int FindIndexToRemove(List<int> wagons, int average)
        {
            int minDiff = int.MaxValue;
            int indexToRemove = 0;
            for (int i = 0; i < wagons.Count; i++)
            {
                int diff = Math.Abs(wagons[i] - average);
                if (diff < minDiff)
                {
                    minDiff = diff;
                    indexToRemove = i;
                }
            }
            return indexToRemove;
        }
    }
}
