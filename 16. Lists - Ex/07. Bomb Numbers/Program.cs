using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] input = Console.ReadLine().Split();

            int number = int.Parse(input[0]);
            int power = int.Parse(input[1]);

            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] == number)
                {
                    int left = Math.Max(i - power, 0);

                    int right = Math.Min(i + power, sequence.Count - 1);

                    int lenght = right - left + 1;
                    sequence.RemoveRange(left, lenght);
                    i = 0;
                }
            }
            Console.WriteLine(sequence.Sum());
        }
    }
}
