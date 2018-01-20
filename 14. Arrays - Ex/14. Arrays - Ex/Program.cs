using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Arrays___Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            int counter1 = 0;
            int counter2 = 0;

            for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    counter1++;
                }
                else
                {
                    break;
                }
            }

            for (int i = Math.Min(firstArray.Length, secondArray.Length) - 1; i >= 0; i--)
            {
                int arrayDiff = Math.Abs(firstArray.Length - secondArray.Length);
                try
                {
                    if (secondArray[i] == (firstArray[i + arrayDiff]))
                    {
                        counter2++;
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    break;
                }
            }

            if (!(counter1 == 0 && counter2 == 0))
            {
                Console.WriteLine(Math.Max(counter1, counter2));
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
