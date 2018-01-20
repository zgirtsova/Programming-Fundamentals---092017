using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.__Sequence_of_commands
{
    class Program
    {
        public static void Main(string[] args)
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            string command = Console.ReadLine();

            while (!command.Equals("stop"))
            {
                string[] argsLine = command.Split(' ');

                if (argsLine[0] == "add" || argsLine[0] == "subtract" ||
                    argsLine[0] == "multiply")
                {
                    int[] arguments = new int[2];
                    arguments[0] = int.Parse(argsLine[1]); //index
                    arguments[1] = int.Parse(argsLine[2]); // value

                    PerformAction(ref array, argsLine[0], arguments);
                }
                else if (argsLine[0] == "lshift")
                {
                    ArrayShiftLeft(array);
                }
                else if (argsLine[0] == "rshift")
                {
                    ArrayShiftRight(array);
                }

                Console.WriteLine(string.Join(" ", array));

                command = Console.ReadLine();
            }
        }

        static void PerformAction(ref long[] arr, string action, int[] args)
        {
            int position = args[0] - 1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    arr[position] *= value;
                    break;
                case "add":
                    arr[position] += value;
                    break;
                case "subtract":
                    arr[position] -= value;
                    break;                
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            long num = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = num;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long num = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = num;
        }      
                    
    }
}
