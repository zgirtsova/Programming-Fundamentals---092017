using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

            var input = Console.ReadLine().Split();

            while (input[0] != "print")
            {
                switch (input[0])
                {
                    case "add":
                        {
                            var index = int.Parse(input[1]);
                            var element = int.Parse(input[2]);
                            AddFunction(sequence, index, element);
                            break;
                        }
                    case "addMany":
                        {
                            var index = int.Parse(input[1]);
                            int[] elements = input.Skip(2).Select(int.Parse).ToArray();
                            AddManyFunction(sequence, index, elements);
                            break;
                        }
                    case "contains":
                        {
                            var element = int.Parse(input[1]);
                            ContainsMethod(sequence, element);
                            break;
                        }
                    case "remove":
                        {
                            var index = int.Parse(input[1]);
                            RemoveFunction(sequence, index);
                            break;
                        }
                    case "shift":
                        {
                            var positions = int.Parse(input[1]);
                            ShiftFunction(sequence, positions);
                            break;
                        }
                    case "sumPairs":
                        {
                            SumPairsMethod(sequence);
                            break;
                        }
                }

                //   Console.WriteLine(string.Join(", ", sequence));

                input = Console.ReadLine().Split();
            }
            Console.WriteLine("[{0}]", string.Join(", ", sequence));
        }

        private static void SumPairsMethod(List<int> sequence)
        {
            for (int i = 0; i < sequence.Count - 1; i++)
            {
                var sum = sequence[i] + sequence[i + 1];

                sequence.RemoveAt(i);
                sequence.RemoveAt(i);
                sequence.Insert(i, sum);
            }
        }
        private static void ShiftFunction(List<int> sequence, int positions)
        {
            while (positions > 0)
            {
                var number = sequence.First();

                sequence.RemoveAt(0);

                sequence.Add(number);

                positions--;
            }
        }
        private static void RemoveFunction(List<int> sequence, int index)
        {
            sequence.RemoveAt(index);
        }
        private static void ContainsMethod(List<int> sequence, int element)
        {
            Console.WriteLine(sequence.IndexOf(element));
        }
        private static void AddManyFunction(List<int> sequence, int index, int[] elements)
        {
            sequence.InsertRange(index, elements);
        }
        private static void AddFunction(List<int> sequence, int index, int elements)
        {
            sequence.Insert(index, elements);
        }
    }
}
